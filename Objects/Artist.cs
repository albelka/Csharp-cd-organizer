using System.Collections.Generic;

namespace CDOrganizer.Objects
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _artist;
    private int _id;
    private List<CD> _cds = new List<CD> {};


    public Artist (string artist)
    {
      _artist = artist;
      _instances.Add(this);
      _id = _instances.Count;
      // _cds = new List<CD>;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }
    public int GetId()
    {
      return _id;
    }
    public List<CD> GetCDs()
    {
      return _cds;
    }
    public void AddCD(CD cd)
    {
      _cds.Add(cd);
    }
    public static List<Artist> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static List<CD> matchArtist(string artist, List<CD> cds)
    {
      List<CD> _match = new List<CD> {};
      foreach(CD cd in cds)
      {
        if(cd.GetArtist().Contains(artist))
        {
          _match.Add(cd);
        }
      }
      return _match;
    }
  }
}

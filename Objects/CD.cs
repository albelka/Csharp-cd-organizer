using System.Collections.Generic;

namespace CDOrganizer.Objects
{
  public class CD
  {
    private static List<CD> _instances = new List<CD> {};
    private string _artist;
    private string _title;
    private int _id;

    public CD (string title, string artist)
    {
      _title = title;
      _artist = artist;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
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
    public static List<CD> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

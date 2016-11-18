using Nancy;
using System.Collections.Generic;
using CDOrganizer.Objects;
using System;

namespace CDOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
      {
        Get["/"] = _ => {
          return View["index.cshtml", CD.GetAll()];
        };
        Get["/cds-new"] = _ => {
          return View["cd_form.cshtml"];
        };
        Post["/cds"] = _ => {
          var newCD = new CD(Request.Form["CD-name"], Request.Form["CD-artist"]);

          var allCDs = CD.GetAll();
          return View["index.cshtml", allCDs];
        };
        Post["/artist-search"] = _ =>
        {
          Dictionary<string, object> model = new Dictionary<string, object> ();
          var searchArtist = (Request.Form["search-artist"]);
          var matchList = Artist.matchArtist(searchArtist, CD.GetAll());
          model.Add("artist", searchArtist);
          model.Add("list", matchList);
          return View["artist_result.cshtml", model];
        };
        Get["/search-artist"] = _ =>
        {
          return View["search_by_artist.cshtml"];
        };

    }
  }
}

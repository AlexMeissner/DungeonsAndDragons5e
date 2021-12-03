using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using RestAPI.Utility;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        const string MusicFilepath = @"W:\Music";

        [HttpGet]
        public ActionResult<List<string>> GetPlaylists()
        {
            Logger.Trace("PlaylistController::GetPlaylists");

            try
            {
                return new List<string>(Directory.EnumerateDirectories(MusicFilepath).Select(x => Path.GetFileName(x)));
            }
            catch (Exception exception)
            {
                Logger.Exception(exception);
                return NotFound();
            }
            
        }
    }
}
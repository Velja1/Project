using BussinessLogic;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VesselsController : Controller
    {
        private IVesselsBLL bLL { get; set; }
        public VesselsController(IVesselsBLL _bLL)
        {
            bLL = _bLL;
        }
        [HttpPost, Route("Add")]
        public void Add(Vessels Model)
        {
            bLL.AddVessels(Model);
        }
        [HttpPost, Route("Update")]
        public void Update(Vessels Model)
        {
            bLL.UpdateVessels(Model);
        }
        [HttpPost, Route("Delete")]
        public void Delete(int ID)
        {
            bLL.DeleteVessels(ID);
        }
        [HttpPost, Route("Get")]
        public List<Vessels> Get()
        {
            return bLL.GetVessels();
        }
        [HttpPost, Route("GetByID")]
        public Vessels GetByID(int ID)
        {
            return bLL.GetVesselsByID(ID);
        }
    }
}

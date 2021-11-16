using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using VerticalTec.Backoffice.Models;

namespace VerticalTec.Backoffice.Controllers
{

    [Route("api/[controller]")]
    public class SampleDataController : Controller {

        [HttpGet("GetDataGrid")]
        public object GetDataGrid(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.SampleOrders, loadOptions);
        }

        [HttpGet("GetPivot")]
        public object GetPivot(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.SampleOrders, loadOptions);
        }
    }
}
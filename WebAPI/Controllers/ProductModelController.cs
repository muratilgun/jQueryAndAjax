using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ProductModelController : BaseApiController {
    public ProductModelController(AdventureWorksLTDbContext context) : base() {
      _DbContext = context;
    }

    private AdventureWorksLTDbContext _DbContext;

    private const string ENTITY_NAME = "model";
  
    // GET api/values
    [HttpGet]
    public IActionResult Get() {
      IActionResult ret = null;
      List<ProductModel> list = new List<ProductModel>();

      try {
        if (_DbContext.ProductModels.Count() > 0) {
          // NOTE: Declare 'list' outside the using to avoid it
          // being disposed before it is returned.
          list = _DbContext.ProductModels.OrderBy(p => p.Name).ToList();
          ret = StatusCode(StatusCodes.Status200OK, list);
        } else {
          ret = StatusCode(StatusCodes.Status404NotFound,
                           "No " + ENTITY_NAME + "s exist in the system.");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
           "Exception trying to get all " + ENTITY_NAME + "s.");
      }

      return ret;
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id) {
      IActionResult ret = null;
      ProductModel entity = null;

      try {
        // Declare 'entity' outside the using to avoid it
        // being disposed before it is returned.
        entity = _DbContext.ProductModels.Find(id);
        if (entity != null) {
          ret = StatusCode(StatusCodes.Status200OK, entity);
        } else {
          ret = StatusCode(StatusCodes.Status404NotFound,
                   "Can't find Model ID: " + id.ToString() + ".");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
          "Exception trying to retrieve Model ID: " + id.ToString() + ".");
      }

      return ret;
    }
  }
}
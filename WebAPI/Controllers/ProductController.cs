using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController :
    BaseApiController {
    public ProductController(AdventureWorksLTDbContext context) : base() {
      _DbContext = context;
    }

    private AdventureWorksLTDbContext _DbContext;
    private const string ENTITY_NAME = "product";

    // GET api/values
    [HttpGet]
    public IActionResult Get() {
      IActionResult ret = null;
      List<Product> list = new List<Product>();

      try {
        if (_DbContext.Products.Count() > 0) {
          list = _DbContext.Products.OrderBy(p => p.Name).ToList();
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
      Product entity = null;

      try {
        // Declare 'entity' outside the using to avoid it
        // being disposed before it is returned.
        entity = _DbContext.Products.Find(id);
        if (entity != null) {
          ret = StatusCode(StatusCodes.Status200OK, entity);
        } else {
          ret = StatusCode(StatusCodes.Status404NotFound,
                    "Can't find " + ENTITY_NAME + ": " +
                    id.ToString() + ".");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
          "Exception trying to retrieve " + ENTITY_NAME + " ID: "
               + id.ToString() + ".");
      }

      return ret;
    }

    [HttpPost()]
    public IActionResult Post(Product entity) {
      IActionResult ret = null;

      try {
        if (entity != null) {
          // Fill in required fields not used by client
          entity.ProductCategoryID = 18;
          entity.ProductModelID = 6;
          entity.rowguid = Guid.NewGuid();
          entity.ModifiedDate = DateTime.Now;

          _DbContext.Products.Add(entity);
          _DbContext.SaveChanges();

          ret = StatusCode(StatusCodes.Status201Created, entity);
        } else {
          ret = StatusCode(StatusCodes.Status400BadRequest,
                    "Invalid " + ENTITY_NAME +
                    " object passed to POST method.");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
              "Exception trying to insert a new " + ENTITY_NAME + ".");
      }

      return ret;
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Product entity) {
      IActionResult ret = null;

      try {
        if (entity != null) {
          // Since we don't send all the data down, 
          // read in existing entity, and overwrite changed properties
          Product changed = _DbContext.Products.Find(id);
          if (changed != null) {
            changed.Name = entity.Name;
            changed.ProductNumber = entity.ProductNumber;
            changed.Color = entity.Color;
            changed.StandardCost = entity.StandardCost;
            changed.ListPrice = entity.ListPrice;
            changed.Size = entity.Size;
            changed.Weight = entity.Weight;
            changed.SellStartDate = entity.SellStartDate;
            changed.SellEndDate = entity.SellStartDate;
            changed.ModifiedDate = DateTime.Now;

            _DbContext.Update(changed);
            _DbContext.SaveChanges();
            ret = StatusCode(StatusCodes.Status200OK, changed);
          } else {
            ret = StatusCode(StatusCodes.Status404NotFound,
             "Can't find ProductID=" + id.ToString());
          }
        } else {
          ret = StatusCode(StatusCodes.Status400BadRequest,
                  "Invalid " + ENTITY_NAME +
                  " object passed to PUT method.");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
              "Exception trying to update " + ENTITY_NAME + " ID: "
                  + entity.ProductID.ToString() + ".");
      }

      return ret;
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id) {
      IActionResult ret = null;
      Product entity = null;

      try {
        entity = _DbContext.Products.Find(id);
        if (entity != null) {
          _DbContext.Products.Remove(entity);
          _DbContext.SaveChanges();
          ret = StatusCode(StatusCodes.Status200OK, true);
        } else {
          ret = StatusCode(StatusCodes.Status404NotFound,
                 "Can't find " + ENTITY_NAME + " ID: " + id.ToString()
                 + " to delete.");
        }
      } catch (Exception ex) {
        ret = HandleException(ex,
        "Exception trying to delete " + ENTITY_NAME + "ID: "
          + id.ToString() + ".");
      }

      return ret;
    }
  }
}

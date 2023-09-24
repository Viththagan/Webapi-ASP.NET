using Microsoft.AspNetCore.Mvc;
using webapi_frakliu.Models;

namespace webapi_frakliu.Controllers;

[ApiController]
[Route("[controller]")]
public class ShirtsController : ControllerBase
{
    private List<Shirt> shirts = new()
    {
        new Shirt {Id = 0, Brand = "mbrk", Color = "red", Gender = Gender.Male, Price = 100, Size = 14},
        new Shirt {Id = 1, Brand = "levis", Color = "blue", Gender = Gender.Female, Price = 600, Size = 13},
        new Shirt {Id = 2, Brand = "deedat", Color = "paleblue", Gender = Gender.Male, Price = 200, Size = 16},
        new Shirt {Id = 3, Brand = "ck", Color = "black", Gender = Gender.Male, Price = 150, Size = 14}
    };

    [HttpGet]
    public IActionResult GetShirts()
    {
        return Ok("Reading all the shirts");
    }

    [HttpGet("{id}")]
    public IActionResult GetShirtById(int id)
    {
        if (id < 0)
        {
            return BadRequest();
        }
        Shirt? shirt = shirts.FirstOrDefault(x => x.Id == id);
        return !(shirt == null) ? Ok(shirt) : NotFound();
    }

    [HttpPost]
    public IActionResult CreateShirt([FromBody] Shirt shirt)
    {
        return Ok($" Creating a shirt with \n ID : {shirt.Id} \n Size : {shirt.Size} \n Price : {shirt.Price} \n Color : {shirt.Color}");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateShirt(int id)
    {
        return Ok($"Updating a shirt with ID : {id}");
    }

    [HttpDelete("{id}")]

    // FromHeader, FromRoute, FromQuery, FromBody, FromForm
    public IActionResult DeleteShirt(int id, [FromHeader(Name = "disc")] string discription)
    {
        return Ok($"Deleting a shirt with ID : {id} \n Reason : {discription}");
    }

}


// [ApiController]
// public class ShirtController : ControllerBase
// {
//     [HttpGet]
//     [Route("/shirts")]
//     public string GetShirts()
//     {
//         return  "Reading all the shirts";
//     }

//     [HttpGet]
//     [Route("/shirts/{id}")]
//     public string GetShirtById(int id)
//     {
//         return  $"Reading shirt with ID : {id}";
//     }

//     [HttpPost]
//     [Route("/shirts/")]
//     public string CreateShirt()
//     {
//         return  "Creating a shirt ";
//     }

//     [HttpPut]
//     [Route("/shirts/{id}")]
//     public string UpdateShirt(int id)
//     {
//         return  $"Updating a shirt with ID : {id}";
//     }

//     [HttpDelete]
//     [Route("/shirts/{id}")]
//     public string DeleteShirt(int id)
//     {
//         return  $"Deleting a shirt with ID : {id}";
//     }

// }

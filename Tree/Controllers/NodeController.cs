//using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc;

//namespace Markiian.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class NodeController : ControllerBase
//    {
//        private static List<Node> nodes = new List<Node>();

//        [HttpPost]
//        public IActionResult Create(Node node)
//        {
//            nodes.Add(node);
//            return CreatedAtAction(nameof(GetById), new { id = node.Date }, node);
//        }

//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            return Ok(nodes);
//        }

//        [HttpGet("{id}")]
//        public IActionResult GetById(int id)
//        {
//            var node = nodes.Find(n => n.Date == id);
//            if (node == null)
//            {
//                return NotFound();
//            }
//            return Ok(node);
//        }

//        [HttpPut("{id}")]
//        public IActionResult Update(int id, Node updatedNode)
//        {
//            var node = nodes.Find(n => n.Date == id);
//            if (node == null)
//            {
//                return NotFound();
//            }
//            node.Date = updatedNode.Date;
//            node.Left = updatedNode.Left;
//            node.Right = updatedNode.Right;
//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            var node = nodes.Find(n => n.Date == id);
//            if (node == null)
//            {
//                return NotFound();
//            }
//            nodes.Remove(node);
//            return NoContent();
//        }
//    }
//}

using System.Collections.Generic;
using MaquinaEstados.Data;
using MaquinaEstados.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaquinaEstados.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly MockNoteRepo _repository = new MockNoteRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetAllNotes()
        {
            var noteItems = _repository.GetAppNotes();
            return Ok(noteItems);
        }
        [HttpGet("{id}")] 
        public ActionResult<Note> GetNoteById(int id){
            var noteItem = _repository.GetNoteById(id);
            return Ok(noteItem);
        } 
    
    }
}
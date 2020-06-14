using System.Collections.Generic;
using MaquinaEstados.Models;

namespace MaquinaEstados.Data
{
    public class MockNoteRepo : IMaquinaEstadosRepo
    {
        public IEnumerable<Note> GetAppNotes()
        {
            var notes = new List<Note>{

            new Note{Id= 0 , HowTo="pull from the server", Line="git pull",Platform="GIT" },
        
            new Note{Id= 1 , HowTo="push to the server", Line="git push",Platform="GIT" },
        
           new Note{Id= 2, HowTo="commit changes", Line="git commit",Platform="GIT" }
            };
            return notes; 
        }

        public Note GetNoteById(int Id)
        {
            return new Note{Id= 0 , HowTo="configure git account", Line="git account??",Platform="GIT" };
        }
    }
}
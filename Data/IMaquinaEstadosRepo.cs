using System.Collections.Generic;
using MaquinaEstados.Models;

namespace MaquinaEstados.Data
{
    public interface IMaquinaEstadosRepo
    {
        IEnumerable<Note>GetAppNotes();
        Note GetNoteById(int Id);   
    }
}
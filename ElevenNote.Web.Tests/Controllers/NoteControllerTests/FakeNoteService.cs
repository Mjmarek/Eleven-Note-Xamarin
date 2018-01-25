using ElevenNote.Models;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Web.Tests.Controllers.NoteControllerTests
{
    public class FakeNoteService : INoteService
    {
        public int CreateNoteCallCount { get; private set; }
        public bool CreateNoteReturnValue { private get; set; } = true;

        public bool CreateNote(NoteCreate model)
        {
            CreateNoteCallCount++;

            return CreateNoteReturnValue;
        }

        public IEnumerable<NoteListItem> GetNotes()
        {
            throw new NotImplementedException();
        }

        public NoteDetail GetNoteById(int noteId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNote(NoteEdit model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNote(int noteId)
        {
            throw new NotImplementedException();
        }
    }
}

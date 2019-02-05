using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Additional> Additionals { get; }
        IRepository<AnswerToRequestSpecification> AnswerToRequestSpecifications { get; }
        IRepository<AnswerToRequestToTakeOff> AnswerToRequestToTakeOffs { get; }
        IRepository<Correction> Corrections { get; }
        IRepository<CorrectionStatus> CorrectionStatuss { get; }
        IRepository<Note> Notes { get; }
        IRepository<NoteStatus> NoteStatuss { get; }
        IRepository<RequestForCorrection> RequestForCorrections { get; }
        IRepository<RequestForSpecification> RequestForSpecifications { get; }
        IRepository<RequestForTakeOff> RequestForTakeOffs { get; }
        IRepository<RequestForUpdateStatus> RequestForUpdateStatuss { get; } 
        IRepository<Specification> Specifications { get; }
        IRepository<TakeOff> TakeOffs { get; }
        IRepository<TakeOffStatus> TakeOffStatuss { get; }

        void Save();
    }
}

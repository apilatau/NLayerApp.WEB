using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ComNotHis.DAL.Entities;
using ComNotHis.DAL.Interface;
using ComNotHis.DAL.EF;

namespace ComNotHis.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private CommentsContext db;

        private AdditionalRepository additionalRepository;
        private AnswerToRequestSpecificationRepository answerToRequestSpecificationRepository;
        private AnswerToRequestToTakeOffRepository answerToRequestToTakeOffRepository;
        private CorrectionRepository correctionRepository;
        private CorrectionStatusRepository correctionStatusRepository;
        private NoteRepository noteRepository;
        private NoteStatusRepository noteStatusRepository;
        private RequestForCorrectionRepository requestForCorrectionRepository;
        private RequestForSpecificationRepository requestForSpecificationRepository;
        private RequestForTakeOffRepository requestForTakeOffRepository;
        private RequestForUpdateStatusRepository requestForUpdateStatusRepository;
        private SpecificationRepository specificationRepository;
        private TakeOffRepository takeOffRepository;
        private TakeOffStatusRepository takeOffStatusRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new CommentsContext(connectionString);
        }

        public IRepository<Additional> Additionals
        {
            get
            {
                if (additionalRepository == null)
                    additionalRepository = new AdditionalRepository(db);
                return additionalRepository;
            }
        }

        public IRepository<AnswerToRequestSpecification> AnswerToRequestSpecifications
        {
            get
            {
                if (answerToRequestSpecificationRepository == null)
                    answerToRequestSpecificationRepository = new AnswerToRequestSpecificationRepository(db);
                return answerToRequestSpecificationRepository;
            }
        }

        public IRepository<AnswerToRequestToTakeOff> AnswerToRequestToTakeOffs
        {
            get
            {
                if (answerToRequestToTakeOffRepository == null)
                    answerToRequestToTakeOffRepository = new AnswerToRequestToTakeOffRepository(db);
                return answerToRequestToTakeOffRepository;
            }
        }

        public IRepository<Correction> Corrections
        {
            get
            {
                if (correctionRepository == null)
                    correctionRepository = new CorrectionRepository(db);
                return correctionRepository;
            }
        }

        public IRepository<CorrectionStatus> CorrectionStatuss
        {
            get
            {
                if (correctionStatusRepository == null)
                    correctionStatusRepository = new CorrectionStatusRepository(db);
                return correctionStatusRepository;
            }
        }

        public IRepository<Note> Notes
        {
            get
            {
                if (noteRepository == null)
                    noteRepository = new NoteRepository(db);
                return noteRepository;
            }
        }

        public IRepository<NoteStatus> NoteStatuss
        {
            get
            {
                if (noteStatusRepository == null)
                    noteStatusRepository = new NoteStatusRepository(db);
                return noteStatusRepository;
            }
        }

        public IRepository<RequestForCorrection> RequestForCorrections
        {
            get
            {
                if (requestForCorrectionRepository == null)
                    requestForCorrectionRepository = new RequestForCorrectionRepository(db);
                return requestForCorrectionRepository;
            }
        }

        public IRepository<RequestForSpecification> RequestForSpecifications
        {
            get
            {
                if (requestForSpecificationRepository == null)
                    requestForSpecificationRepository = new RequestForSpecificationRepository(db);
                return requestForSpecificationRepository;
            }
        }

        public IRepository<RequestForTakeOff> RequestForTakeOffs
        {
            get
            {
                if (requestForTakeOffRepository == null)
                    requestForTakeOffRepository = new RequestForTakeOffRepository(db);
                return requestForTakeOffRepository;
            }
        }

        public IRepository<RequestForUpdateStatus> RequestForUpdateStatuss
        {
            get
            {
                if (requestForUpdateStatusRepository == null)
                    requestForUpdateStatusRepository = new RequestForUpdateStatusRepository(db);
                return requestForUpdateStatusRepository;
            }
        }

        public IRepository<Specification> Specifications
        {
            get
            {
                if (specificationRepository == null)
                    specificationRepository = new SpecificationRepository(db);
                return specificationRepository;
            }
        }

        public IRepository<TakeOff> TakeOffs
        {
            get
            {
                if (takeOffRepository == null)
                    takeOffRepository = new TakeOffRepository(db);
                return takeOffRepository;
            }
        }

        public IRepository<TakeOffStatus> TakeOffStatuss
        {
            get
            {
                if (takeOffStatusRepository == null)
                    takeOffStatusRepository = new TakeOffStatusRepository(db);
                return takeOffStatusRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}

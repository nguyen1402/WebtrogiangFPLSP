using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class CopySubjectInClass : ICopySubjectInClass
    {
        private IRepository<LessonCP> _LessonCPrepository;
        private IRepository<LessonContentCP> _LessonContentCPrepository;
        private IRepository<ResourceLink> _ResourceLinkCPrepository;
        private IRepository<SubjectCP> _SubjectCPrepository;
        private IRepository<QuizCP> _QuizCPrepository;
        private IRepository<QuizQuestionCP> _QuizQuestionCPrepository;
        private IRepository<QuizQuestionQuizCP> _QuizQuestionQuizCPrepository;
        private IRepository<QuizAnswerCP> _QuizAnswerCPrepository;

        private IRepository<LectuterSpecializedCP> _LectuterSpecializedCPrepository;
        private IRepository<SpecializedCP> _SpecializedCPrepository;
        private IRepository<SpecializedSubjectCP> _SpecializedSubjectCPrepository;


        private IRepository<KindoOfQuestionCP> _KindoOfQuestionCPrerepository;
        private IRepository<QuestionType> _QuestionTyperepository;

        private IRepository<LectuterSpecializedUP> _LectuterSpecializedUPrepository;
        private IRepository<SpecializedUP> _SpecializedUPrepository;
        private IRepository<SpecializedSubjectUP> _SpecializedSubjectUPrepository;

        private IRepository<LessonUP> _LessonUPrepository;
        private IRepository<LessonContentUP> _LessonContentUPrepository;
        private IRepository<ResourceLinkUP> _ResourceLinkUPrepository;
        private IRepository<SubjectUP> _SubjectUPrepository;
        private IRepository<QuizUP> _QuizUPrepository;
        private IRepository<QuizQuestionUP> _QuizQuestionUPrepository;
        private IRepository<QuizQuestionQuizUP> _QuizQuestionQuizUPrepository;
        private IRepository<AnswerUP> _AnswerUPrepository;

        public CopySubjectInClass(IRepository<LessonCP> lessonCPrepository, IRepository<LessonContentCP> lessonContentCPrepository, IRepository<ResourceLink> resourceLinkCPrepository, IRepository<SubjectCP> subjectCPrepository, IRepository<QuizCP> quizCPrepository, IRepository<QuizQuestionCP> quizQuestionCPrepository, IRepository<QuizQuestionQuizCP> quizQuestionQuizCPrepository, IRepository<QuizAnswerCP> quizAnswerCPrepository, IRepository<LectuterSpecializedCP> lectuterSpecializedCPrepository, IRepository<SpecializedCP> specializedCPrepository, IRepository<SpecializedSubjectCP> specializedSubjectCPrepository, IRepository<KindoOfQuestionCP> kindoOfQuestionCPrerepository, IRepository<QuestionType> questionTyperepository, IRepository<LectuterSpecializedUP> lectuterSpecializedUPrepository, IRepository<SpecializedUP> specializedUPrepository, IRepository<SpecializedSubjectUP> specializedSubjectUPrepository, IRepository<LessonUP> lessonUPrepository, IRepository<LessonContentUP> lessonContentUPrepository, IRepository<ResourceLinkUP> resourceLinkUPrepository, IRepository<SubjectUP> subjectUPrepository, IRepository<QuizUP> quizUPrepository, IRepository<QuizQuestionUP> quizQuestionUPrepository, IRepository<QuizQuestionQuizUP> quizQuestionQuizUPrepository, IRepository<AnswerUP> answerUPrepository)
        {
            _LessonCPrepository = lessonCPrepository;
            _LessonContentCPrepository = lessonContentCPrepository;
            _ResourceLinkCPrepository = resourceLinkCPrepository;
            _SubjectCPrepository = subjectCPrepository;
            _QuizCPrepository = quizCPrepository;
            _QuizQuestionCPrepository = quizQuestionCPrepository;
            _QuizQuestionQuizCPrepository = quizQuestionQuizCPrepository;
            _QuizAnswerCPrepository = quizAnswerCPrepository;
            _LectuterSpecializedCPrepository = lectuterSpecializedCPrepository;
            _SpecializedCPrepository = specializedCPrepository;
            _SpecializedSubjectCPrepository = specializedSubjectCPrepository;
            _KindoOfQuestionCPrerepository = kindoOfQuestionCPrerepository;
            _QuestionTyperepository = questionTyperepository;
            _LectuterSpecializedUPrepository = lectuterSpecializedUPrepository;
            _SpecializedUPrepository = specializedUPrepository;
            _SpecializedSubjectUPrepository = specializedSubjectUPrepository;
            _LessonUPrepository = lessonUPrepository;
            _LessonContentUPrepository = lessonContentUPrepository;
            _ResourceLinkUPrepository = resourceLinkUPrepository;
            _SubjectUPrepository = subjectUPrepository;
            _QuizUPrepository = quizUPrepository;
            _QuizQuestionUPrepository = quizQuestionUPrepository;
            _QuizQuestionQuizUPrepository = quizQuestionQuizUPrepository;
            _AnswerUPrepository = answerUPrepository;
        }








        ////Lấy toàn bộ danh sách
        //public async Task<IQueryable<LessonCP>> GetAllLessonCP()
        //{
        //    var LessonCP = _LessonCPrepository.AsQueryable().ToList();
        //    return LessonCP;
        //}


        ////Lấy toàn bộ danh sách LessonContentCP
        //public async Task<IQueryable<LessonContentCP>> GetAllLessonContentCP()
        //{
        //    var LessonContentCP = _LessonContentCPrepository.AsQueryable().ToList();
        //    return LessonContentCP;
        //}


        ////Lấy toàn bộ danh sách ResourceLink
        //public async Task<IQueryable<ResourceLink>> GetAllResourceLinkCP()
        //{
        //    var ResourceLink = _ResourceLinkCPrepository.AsQueryable().ToList();
        //    return ResourceLink;
        //}


        ////Lấy toàn bộ danh sách SubjectCP
        //public async Task<IQueryable<SubjectCP>> GetAllSubjectCP()
        //{
        //    var SubjectCP = _SubjectCPrepository.AsQueryable().ToList();
        //    return SubjectCP;
        //}


        ////Lấy toàn bộ danh sách QuizCP
        //public async Task<IQueryable<QuizCP>> GetAllQuizCP()
        //{
        //    var QuizCP = _QuizCPrepository.AsQueryable().ToList();
        //    return QuizCP;
        //}

        ////Lấy toàn bộ danh sách QuizQuestionCP
        //public async Task<IQueryable<QuizQuestionCP>> GetAllQuizQuestionCP()
        //{
        //    var QuizQuestionCP = _QuizQuestionCPrepository.AsQueryable().ToList();
        //    return QuizQuestionCP;
        //}


        ////Lấy toàn bộ danh sách QuizQuestionQuizCP
        //public async Task<IQueryable<QuizQuestionQuizCP>> GetAllQuizQuestionQuizCP()
        //{
        //    var QuizQuestionQuizCP = _QuizQuestionQuizCPrepository.AsQueryable().ToList();
        //    return QuizQuestionQuizCP;
        //}


        ////Lấy toàn bộ danh sách QuizAnswerCP
        //public async Task<IQueryable<QuizAnswerCP>> GetAllQuizAnswerCP()
        //{
        //    var QuizAnswerCP = _QuizAnswerCPrepository.AsQueryable().ToList();
        //    return QuizAnswerCP;
        //}


        ////Lấy toàn bộ danh sách KindoOfQuestionCP
        //public async Task<IQueryable<KindoOfQuestionCP>> GetAllKindoOfQuestionCP()
        //{
        //    var KindoOfQuestionCP = _KindoOfQuestionCPrerepository.AsQueryable().ToList();
        //    return KindoOfQuestionCP;
        //}

        ////Lấy toàn bộ danh sách QuestionType
        //public async Task<IQueryable<QuestionType>> GetAllQuestionType()
        //{
        //    var QuestionType = _QuestionTyperepository.AsQueryable().ToList();
        //    return QuestionType;
        //}


        ////Lấy toàn bộ danh sách LessonUP
        //public async Task<IQueryable<LessonUP>> GetAllLessonUP()
        //{
        //    var LessonUP = _LessonUPrepository.AsQueryable().ToList();
        //    return LessonUP;
        //}


        ////Lấy toàn bộ danh sách LessonContentUP
        //public async Task<IQueryable<LessonContentUP>> GetAllLessonContentUP()
        //{
        //    var LessonContentUP = _LessonContentUPrepository.AsQueryable().ToList();
        //    return LessonContentUP;
        //}


        ////Lấy toàn bộ danh sách ResourceLinkUP
        //public async Task<IQueryable<ResourceLinkUP>> GetAllResourceLinkUP()
        //{
        //    var ResourceLinkUP = _ResourceLinkUPrepository.AsQueryable().ToList();
        //    return ResourceLinkUP;
        //}


        ////Lấy toàn bộ danh sách SubjectUP
        //public async Task<IQueryable<SubjectUP>> GetAllSubjectUP()
        //{
        //    var SubjectUP = _SubjectUPrepository.AsQueryable().ToList();
        //    return SubjectUP;
        //}

        ////Lấy toàn bộ danh sách QuizUP
        //public async Task<IQueryable<QuizUP>> GetAllQuizUP()
        //{
        //    var QuizUP = _QuizUPrepository.AsQueryable().ToList();
        //    return QuizUP;
        //}

        ////Lấy toàn bộ danh sách QuizQuestionUP
        //public async Task<IQueryable<QuizQuestionUP>> GetAllQuizQuestionUP()
        //{
        //    var QuizQuestionUP = _QuizQuestionUPrepository.AsQueryable().ToList();
        //    return QuizQuestionUP;
        //}




        ////Lấy toàn bộ danh sách QuizQuestionQuizUP
        //public async Task<IQueryable<QuizQuestionQuizUP>> GetAllQuizQuestionQuizUP()
        //{
        //    var QuizQuestionQuizUP = _QuizQuestionQuizUPrepository.AsQueryable().ToList();
        //    return QuizQuestionQuizUP;
        //}


        ////Lấy toàn bộ danh sách AnswerUP
        //public async Task<IQueryable<AnswerUP>> GetAllAnswerUP()
        //{
        //    var AnswerUP = _AnswerUPrepository.AsQueryable().ToList();
        //    return AnswerUP;
        //}


        public async Task<string> Copy(Guid idsubject)
        {

            var lstSubjectCP = _SubjectCPrepository.AsQueryable().ToList();
            var lstLessonCP = _LessonCPrepository.AsQueryable().ToList();
            var idLessonCP = _LessonCPrepository.AsQueryable().Where(c => c.SubjectId == idsubject).Select(c=>c.Id).FirstOrDefault();
            var lstLessonContentCP = _LessonContentCPrepository.AsQueryable().ToList();
            var lstResourceLinkCP = _ResourceLinkCPrepository.AsQueryable().ToList();


            var lstQuizCP = _QuizCPrepository.AsQueryable().ToList();
            var idquizCP = _QuizCPrepository.AsQueryable().Where(c => c.SubjectId == idsubject).Select(c => c.Id).FirstOrDefault();
            var lstQuizQuestionQuizCP = _QuizQuestionQuizCPrepository.AsQueryable().ToList();
            var lstQuizQuestionCP = _QuizQuestionCPrepository.AsQueryable().ToList();
            //var idquizquestionCP = _QuizQuestionCPrepository.AsQueryable().Where(c => c.Id == idquizCP).Select(c => c.Id).FirstOrDefault();
            var lstQuizAnswerCP = _QuizAnswerCPrepository.AsQueryable().ToList();
            var lstKindoOfQuestionCP = _KindoOfQuestionCPrerepository.AsQueryable().ToList();
            var lstQuestionType = _QuestionTyperepository.AsQueryable().ToList();

            //var lstSpecializedCP = _SpecializedCPrepository.AsQueryable().ToList();
            //var lstLectuterSpecializedCP = _LectuterSpecializedCPrepository.AsQueryable().ToList();
            //var lstSpecializedSubjectCP = _SpecializedSubjectCPrepository.AsQueryable().ToList();

            //var lstSpecializedUP = _SpecializedUPrepository.AsQueryable().ToList();
            //var lstLectuterSpecializedUP = _LectuterSpecializedUPrepository.AsQueryable().ToList();
            //var lstSpecializedSubjectUP = _SpecializedSubjectUPrepository.AsQueryable().ToList();

            var lstLessonUP = _LessonUPrepository.AsQueryable().ToList();
            var lstLessonContentUP = _LessonContentUPrepository.AsQueryable().ToList();
            var lstResourceLinkUP = _ResourceLinkUPrepository.AsQueryable().ToList();
            var lstSubjectUP = _SubjectUPrepository.AsQueryable().ToList();
            var lstQuizUP = _QuizUPrepository.AsQueryable().ToList();
            var lstQuizQuestionUP = _QuizQuestionUPrepository.AsQueryable().ToList();
            var lstQuizQuestionQuizUP = _QuizQuestionQuizUPrepository.AsQueryable().ToList();
            var lstAnswerUP = _AnswerUPrepository.AsQueryable().ToList();


            //try
            //{
            //    foreach (var x in lstSpecializedCP.OrderBy(c => c.Level))
            //    {
            //        if (lstSpecializedUP.Any(c => c.Id == x.Id))
            //        {
            //            continue;
            //        }
            //        var SpecializedUP = new SpecializedUP()
            //        {
            //            CreatedBy = x.CreatedBy,
            //            CreatedTime = x.CreatedTime,
            //            DeletedBy = x.DeletedBy,
            //            DeletedTime = x.DeletedTime,
            //            Id = x.Id,
            //            IsDeleted = x.IsDeleted,
            //            Level = x.Level,
            //            ModifiedBy = x.ModifiedBy,
            //            ModifiedTime = x.ModifiedTime,
            //            SpecialityId = x.IdSpeciality,
            //            SpecializedCode = x.SpecializedCode,
            //            SpecializationName = x.SpecializationName,
            //            Status = x.Status,
            //            Image = x.Image

            //        };

            //        await _SpecializedUPrepository.AddAsync(SpecializedUP);
            //        await _SpecializedUPrepository.SaveChangesAsync();
            //    }
            //}
            //catch (Exception)
            //{

            //    return "SpecializedUP";
            //}

            //try
            //{
            //    foreach (var x in lstLectuterSpecializedCP)
            //    {
            //        if (lstLectuterSpecializedUP.Any(c => c.SpecializedId == x.SpecializedId && c.LectuterId == c.LectuterId))
            //        {
            //            continue;
            //        }
            //        var LectuterSpecializedUP = new LectuterSpecializedUP()
            //        {
            //            LectuterId = x.LectuterId,
            //            SpecializedId = x.SpecializedId,
            //            Status = x.Status
            //        };

            //        await _LectuterSpecializedUPrepository.AddAsync(LectuterSpecializedUP);
            //        await _LectuterSpecializedUPrepository.SaveChangesAsync();
            //    }
            //}
            //catch (Exception)
            //{

            //    return "LectuterSpecializedUP";
            //}


            try
            {
                foreach (var x in lstSubjectCP)
                {
                    if (lstSubjectUP.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var SubjectUP = new SubjectUP()
                    {
                        EndDay = x.EndDay,
                        CreatedBy = x.CreatedBy,
                        CreatedDay = x.CreatedDay,
                        DeletedBy = x.DeletedBy,
                        CreatedTime = x.CreatedTime,
                        DeletedTime = x.DeletedTime,
                        IsDeleted = x.IsDeleted,
                        Id = x.Id,
                        Image = x.Image,
                        IsDemo = x.IsDemo,
                        SubjectCode = x.SubjectCode,
                        StartDay = x.StartDay,
                        ModifiedBy = x.ModifiedBy,
                        ModifiedTime = x.ModifiedTime,
                        Status = x.Status,
                        SubjectName = x.SubjectName,
                        TotalOfSub = x.TotalOfSub
                        
                    };

                    await _SubjectUPrepository.AddAsync(SubjectUP);
                    await _SubjectUPrepository.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                return "SubjectUP";
            }

            //try
            //{
            //    foreach (var x in lstSpecializedSubjectCP)
            //    {
            //        if (lstSpecializedSubjectUP.Any(c => c.SubjectId == x.SubjectId && c.SpecializedId == x.SpecializedId))
            //        {
            //            continue;
            //        }
            //        var SpecializedSubjectUP = new SpecializedSubjectUP()
            //        {
            //            SpecializedId = x.SpecializedId,
            //            Status = (int)x.Status,
            //            SubjectId = x.SubjectId

            //        };

            //        await _SpecializedSubjectUPrepository.AddAsync(SpecializedSubjectUP);
            //        await _SpecializedSubjectUPrepository.SaveChangesAsync();
            //    }
            //}
            //catch (Exception)
            //{

            //    return "SpecializedSubjectUP";
            //}

            try
            {
                foreach (var x in lstLessonCP)
                {
                    if (lstLessonUP.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var LessonUP = new LessonUP()
                    {
                        SubjectId = x.SubjectId,
                        Descriptions = x.Descriptions,
                        LessonCode = x.LessonCode,
                        LessonName = x.LessonName,
                        Status = x.Status,
                        IsCompleted = false,
                        Id = x.Id,
                        CreatedBy = x.CreatedBy,
                        CreatedTime = x.CreatedTime,
                        DeletedBy = x.DeletedBy,
                        DeletedTime = x.DeletedTime,
                        IsDeleted = x.IsDeleted,
                        ModifiedBy = x.ModifiedBy,
                        ModifiedTime = x.ModifiedTime,
                        IndexOfLesson = x.IndexOfLesson

                    };

                    await _LessonUPrepository.AddAsync(LessonUP);
                    await _LessonUPrepository.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                return "LessonUP";
            }
            try
            {
                foreach (var item in lstResourceLinkCP)
                {
                    if (lstResourceLinkUP.Any(c => c.Id == item.Id))
                    {
                        continue;
                    }

                    var resourceLinkUPCreate = new ResourceLinkUP()
                    {
                        Descriptions = item.Descriptions,
                        Path = item.Path,
                        Id = item.Id,
                        Status = item.Status,
                        ResourcesTitle = item.ResourcesTitle,
                        IndexOfVideo = item.IndexOfVideo,
                        DateCreated = item.DateCreated,
                        IdSubject = item.IdSubject
                        

                    };
                    await _ResourceLinkUPrepository.AddAsync(resourceLinkUPCreate);
                    await _ResourceLinkUPrepository.SaveChangesAsync();

                }

            }
            catch (Exception)
            {

                return "resourceLinkUPCreate";
            }
            try
            {
                foreach (var x in lstLessonContentCP)
                {
                    if (lstLessonContentUP.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var lessonContentUPCreate = new LessonContentUP()
                    {
                        Content = x.Content,
                        Descriptions = x.Descriptions,
                        Id = x.Id,
                        LessonContentCode = x.LessonContentCode,
                        LessonContentName = x.LessonContentName,
                        LessonId = x.IdLesson,
                        ResuorceLinkId = x.ResourceLinkId,
                        Status = x.Status,
                        CreatedBy = x.CreatedBy,
                        CreatedTime = x.CreatedTime,
                        DeletedBy = x.DeletedBy,
                        DeletedTime = x.DeletedTime,
                        IsDeleted = x.IsDeleted,
                        ModifiedBy = x.ModifiedBy,
                        ModifiedTime = x.ModifiedTime,
                        IndexOfLessonContent = x.IndexOfLessonContent
                        

                    };
                    await _LessonContentUPrepository.AddAsync(lessonContentUPCreate);
                    await _LessonContentUPrepository.SaveChangesAsync();

                }
            }
            catch (Exception)
            {

                return "lessonContentUPCreate";
            }


            try
            {
                foreach (var x in lstQuizCP)
                {
                    if (lstQuizUP.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var QuizUP = new QuizUP()
                    {
                        EndDay = x.EndDay,
                        MaxTurn = x.MaxTurn,
                        QuizName = x.QuizName,
                        QuizTitle = x.QuizTitle,
                        Descriptions = x.Descriptions,
                        StartDay = x.StartDay,
                        SubjectId = x.SubjectId,
                        Id = x.Id,
                        Status = x.Status,
                        CreatedBy = x.CreatedBy,
                        CreatedTime = x.CreatedTime,
                        DeletedBy = x.DeletedBy,
                        DeletedTime = x.DeletedTime,
                        IsDeleted = x.IsDeleted,
                        ModifiedBy = x.ModifiedBy,
                        ModifiedTime = x.ModifiedTime
                        

                    };
                    await _QuizUPrepository.AddAsync(QuizUP);
                    await _QuizUPrepository.SaveChangesAsync();

                }
            }
            catch (Exception)
            {
                return "QuizUP";
            }
            try
            {
                foreach (var x in lstKindoOfQuestionCP)
                {
                    if (lstQuestionType.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var QuestionType = new QuestionType()
                    {
                        QuestionTypeName = x.QuestionTypeName,
                        Id = x.Id,
                        QuestionForm = x.QuestionForm
                        


                    };
                    await _QuestionTyperepository.AddAsync(QuestionType);
                    await _QuestionTyperepository.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                return "lstQuestionType";
            }

            try
            {
                foreach (var x in lstQuizQuestionCP)
                {
                    if (lstQuizQuestionUP.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var QuizQuestionUP = new QuizQuestionUP()
                    {
                        QuestionCode = x.QuestionCode,
                        QuestionName = x.QuestionName,
                        QuestionTital = x.QuestionTital,
                        QuestionTypeId = x.KindoOfQuestionId,
                        ContentQuestion = x.ContentQuestion,
                        Id = x.Id,
                        Status = x.Status
                        
                    };
                    await _QuizQuestionUPrepository.AddAsync(QuizQuestionUP);
                    await _QuizQuestionUPrepository.SaveChangesAsync();
                }

            }
            catch (Exception)
            {

                return "QuestionType";
            }
            try
            {
                foreach (var x in lstQuizQuestionQuizCP)
                {
                    if (lstQuizQuestionQuizUP.Any(c => c.QuizId == x.QuizId && c.QuizQuestionId == x.QuizQuestionId))
                    {
                        continue;
                    }
                    var QuizQuestionQuizUP = new QuizQuestionQuizUP()
                    {
                        QuizId = x.QuizId,
                        QuizQuestionId = x.QuizQuestionId,
                        Status = x.Status
                        



                    };
                    await _QuizQuestionQuizUPrepository.AddAsync(QuizQuestionQuizUP);
                    await _QuizQuestionQuizUPrepository.SaveChangesAsync();
                }

            }
            catch (Exception)
            {

                return "QuizQuestionQuizUP";
            }
            try
            {
                foreach (var x in lstQuizAnswerCP)
                {
                    if (lstAnswerUP.Any(c => c.Id == x.Id))
                    {
                        continue;
                    }
                    var AnswerUP = new AnswerUP()
                    {
                        Answer = x.Answer,
                        Id = x.Id,
                        IsCorrect = x.IsCorrect,
                        QuizQuestionId = x.IdQuizQuestion,
                        Status = 0
                        

                    };
                    await _AnswerUPrepository.AddAsync(AnswerUP);
                    await _AnswerUPrepository.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                return "AnswerUP";
            }

            return "Thành công";

        }


    }
}

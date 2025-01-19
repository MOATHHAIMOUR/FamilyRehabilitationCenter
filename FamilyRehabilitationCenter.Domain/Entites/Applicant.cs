namespace FamilyRehabilitationCenter.Domain.Entites
{
    public class Applicant
    {

        public int ApplicantId { get; set; }

        // Navigation Properties
        public int UserId { get; set; }
        public int ClassificationId { get; set; }
        public int EducationalInfoId { get; set; }
        public int ApplicantLocationId { get; set; }
        public int BirthLocationId { get; set; }

        //DONE
        public User User { get; set; } = null!;
        //DONE
        public BirthLocation BirthLocation { get; set; } = null!;
        //DONE
        public ApplicantLocationInfo ApplicantLocation { get; set; } = null!;
        //DONE
        public EducationalInfo EducationalInfo { get; set; } = null!;
        //DONE
        public ApplicantClassification ApplicantClassification { get; set; } = null!;
        //DONE
        public ICollection<Relative> Relatives { get; set; } = null!;
        //DONE
        //DONE
        public ICollection<ApplicantInsuranceInfo> ApplicantInsuranceInfo { get; set; } = null!;
        //DONE
        public ICollection<ApplicantsComplaints> ApplicantsComplaints { get; set; } = new List<ApplicantsComplaints>();

        //DONE
        public ICollection<ApplicantWorkInfo>? WorkInfos { get; set; }

        public ICollection<ApplicantParentInfo>? Parents { get; set; }


    }
}

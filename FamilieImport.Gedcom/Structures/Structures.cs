using FamilieImport.Gedcom.Models;
using GenDateTools;
using System.Collections.Generic;

namespace FamilieImport.Gedcom.Structures
{
    public class HeaderRecord
    {
        public string ApprovedSystemId { get; set; }
        public string VersionNumber { get; set; }
        public string NameOfProduct { get; set; }
        public string NameOfBusiness { get; set; }
        public AddressStructure Address { get; set; }
        public string NameOfSourceData { get; set; }
        public GenDate PublicationDate { get; set; }
        public string CopyrightSourceData { get; set; }
        public string ReceivingSystemName { get; set; }
        public GenDate TransmissionDate { get; set; }
        public string TransmissionTime { get; set; }
        public GedcomXref Submitter { get; set; }
        public GedcomXref Submission { get; set; }
        public string FileName { get; set; }
        public string CopyrightGedcomFile { get; set; }
        public string GedcomVersionNumber { get; set; }
        public string GedcomForm { get; set; }
        public CharacterSet CharacterSet { get; set; }
        public string CharacterSetVersionNumber { get; set; }
        public string LanguageOfText { get; set; }
        public string PlaceHierarchy { get; set; }
        public string GedcomContentDescription { get; set; }
    }

    public class FamilyRecord
    {
        public GedcomXref Xref { get; set; }
        public RestrictionNotice RestrictionNotice { get; set; }
        public ICollection<FamilyEventStructure> FamilyEvents { get; set; }
        public GedcomXref Husband { get; set; }
        public GedcomXref Wife { get; set; }
        public GedcomXref Child { get; set; }
        public int CountOfChildren { get; set; }
        public ICollection<GedcomXref> Submitters { get; set; }
        public ICollection<UserReference> UserReferences { get; set; }
        public string AutomatedRecordId { get; set; }
        public ChangeDate ChangeDate { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ICollection<MultimediaLink> MultimediaLinks { get; set; }
    }

    public class IndividualRecord
    {
        public GedcomXref Xref { get; set; }
        public RestrictionNotice RestrictionNotice { get; set; }
        public ICollection<PersonalNameStructure> Names { get; set; }
        public SexValue SexValue { get; set; }
        public ICollection<IndividualEventStructure> Events { get; set; }
        public ICollection<IndividualAttributeStructure> Attributes { get; set; }
        public ICollection<ChildToFamilyLink> ChildToFamilyLinks { get; set; }
        public ICollection<SpouseToFamilyLink> SpouseToFamilyLinks { get; set; }
        public ICollection<GedcomXref> Submitters { get; set; }
        public ICollection<AssociationStructure> Associations { get; set; }
        public string PermanentRecordFileNumber { get; set; }
        public string AncestralFileNumber { get; set; }
        public ICollection<UserReference> UserReferences { get; set; }
        public string AutomatedRecordId { get; set; }
        public ChangeDate ChangeDate { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ICollection<MultimediaLink> MultimediaLinks { get; set; }
    }

    public class MultimediaRecord : MultimediaLink
    {
        public ICollection<UserReference> UserReferences { get; set; }
        public string AutomatedRecordId { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ChangeDate ChangeDate { get; set; }
    }

    public class NoteRecord : NoteStructure
    {
        public ICollection<UserReference> UserReferences { get; set; }
        public string AutomatedRecordId { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ChangeDate ChangeDate { get; set; }
    }

    public class RepositoryRecord
    {
        public GedcomXref Xref { get; set; }
        public string NameOfRepository { get; set; }
        public ICollection<AddressStructure> Addresses { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<UserReference> UserReferences { get; set; }
        public string AutomatedRecordId { get; set; }
        public ChangeDate ChangeDate { get; set; }
    }

    public class SourceRecord
    {
        public GedcomXref Xref { get; set; }
        public ICollection<string> EventsRecorded { get; set; }
        public GenDate DatePeriod { get; set; }
        public string PlaceName { get; set; }
        public string ResponsiblyAgency { get; set; }
        public ICollection<NoteStructure> EventNotes { get; set; }
        public string SourceOrginator { get; set; }
        public string SourceDescriptiveTitle { get; set; }
        public string SourceFiledByEntry { get; set; }
        public string SourcePublicationFacts { get; set; }
        public string TextFromSource { get; set; }
        public ICollection<SourceRepositoryCitatation> SourceRepositoryCitatations { get; set; }
        public ICollection<UserReference> UserReferences { get; set; }
        public string AutomatedRecordId { get; set; }
        public ChangeDate ChangeDate { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<MultimediaLink> MultimediaLinks { get; set; }
    }

    public class UserReference
    {
        public string UserReferenceNumber { get; set; }
        public string UserReferenceType { get; set; }
    }

    public class AddressStructure
    {
        public string AddressLine { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public ICollection<string> PhoneNumbers { get; set; }
        public ICollection<string> AddressEmails { get; set; }
        public ICollection<string> AddressFaxes { get; set; }
        public ICollection<string> AddressWebPages { get; set; }
    }

    public class AgeAtEvent
    {
        public string Age { get; set; }
    }

    public class AssociationStructure
    {
        public GedcomXref Xref { get; set; }
        public string RelationDescription { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
    }

    public class ChangeDate
    {
        public GenDate Date { get; set; }
        public string Time { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
    }

    public class ChildToFamilyLink
    {
        public GedcomXref Xref { get; set; }
        public PedigreeLinkageType PedigreeLinkageType { get; set; }
        public ChildLinkageStatus ChildLinkageStatus { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
    }

    public class EventDetail
    {
        public string Classification { get; set; }
        public GenDate Date { get; set; }
        public PlaceStructure Place { get; set; }
        public AddressStructure Address { get; set; }
        public string ResponsibleAgency { get; set; }
        public string ReligiousAffiliation { get; set; }
        public string CauseOfEvent { get; set; }
        public RestrictionNotice RestrictionNotice { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ICollection<MultimediaLink> MultimediaLinks { get; set; }
    }

    public class FamilyEventDetail
    {
        public AgeAtEvent HusbandAgeAtEvent { get; set; }
        public AgeAtEvent WifeAgeAtEvent { get; set; }
        public EventDetail EventDetail { get; set; }
    }

    public class FamilyEventStructure
    {
        public FamilyEventType FamilyEventType { get; set; }
        public FamilyEventDetail FamilyEventDetail { get; set; }
    }

    public class IndividualEventDetail
    {
        public EventDetail EventDetail { get; set; }
        public AgeAtEvent AgeAtEvent { get; set; }
    }

    public class IndividualAttributeStructure
    {
        public IndividualAttributeType IndividualAttributeType { get; set; }
        public string AttributeText { get; set; }
        public IndividualEventDetail IndividualEventDetail { get; set; }
    }

    public class IndividualEventStructure
    {
        public IndividualEventType IndividualEventType { get; set; }
        public IndividualEventDetail IndividualEventDetail { get; set; }
        public GedcomXref Family { get; set; }
        public string AdoptedByWhichParent { get; set; }
    }

    public class MultimediaLink
    {
        public GedcomXref Xref { get; set; }
        public string File { get; set; }
        public MultimediaFormat Format { get; set; }
        public SourceMediaType MediaType { get; set; }
        public string Title { get; set; }
    }

    public class NoteStructure
    {
        public GedcomXref Xref { get; set; }
        public string Text { get; set; }
    }

    public class PersonalNameStructure
    {
        public string NamePersonal { get; set; }
        public NameType NameType { get; set; }
        public string NamePiecePrefix { get; set; }
        public string NamePieceGiven { get; set; }
        public string NamePieceNickname { get; set; }
        public string NamePieceSurnamePrefix { get; set; }
        public string NamePieceSurname { get; set; }
        public string NamePieceSuffix { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
    }

    public class PlaceStructure
    {
        public string PlaceName { get; set; }
        public string PlaceHierarchy { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
    }

    public class SourceCitation
    {
        public GedcomXref Xref { get; set; }
        public string SourceDescription { get; set; }
        public string EventName { get; set; }
        public string EventRole { get; set; }
        public GenDate RecordingDate { get; set; }
        public string TextFromSource { get; set; }
        public ICollection<MultimediaLink> MultimediaLinks { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public CertaintyAssessment Certainty { get; set; }
    }

    public class SourceRepositoryCitatation
    {
        public GedcomXref Xref { get; set; }
        public NoteStructure NoteStructure { get; set; }
        public string CallNumber { get; set; }
        public SourceMediaType SourceMediaType { get; set; }
    }

    public class SpouseToFamilyLink
    {
        public GedcomXref Xref { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
    }

    public enum CharacterSet
    {
        Ansel = 0,
        Utf8 = 1, 
        Unicode = 2,
        Ascii = 3,
    }

    public enum RestrictionNotice
    {
        Confidential = 0, 
        Locked = 1, 
        Privacy = 2,
    }

    public enum SexValue
    {
        Male = 'M',
        Female = 'F',
        Undetermined = 'U',
    }

    public enum FamilyEventType
    {
    }

    public enum IndividualAttributeType
    {
    }

    public enum IndividualEventType
    {
    }

    public enum NameType
    {
        AlsoKnownAs = 0,
        Birth = 1,
        Immigrant = 2,
        Maiden = 3,
        Married = 4,
        UserDefined = 5,
    }

    public enum CertaintyAssessment
    {
        Unreliable = 0,
        Questionable = 1,
        Secondary = 2,
        Primary = 3,
    }

    public enum ChildLinkageStatus
    {
        Challenged = 0,
        Disproven = 1,
        Proven = 2,
    }

    public enum PedigreeLinkageType
    {
        Adopted = 0,
        Birth = 1,
        Foster = 2,
        Sealing = 3,
    }

    public enum MultimediaFormat
    {
        Mmp = 0,
        Gif = 1,
        Jpg = 2,
        Ole = 3,
        Pcx = 4,
        Tif = 5,
        Wav = 6,
    }

    public enum SourceMediaType
    {
        Audio = 0,
        Book = 1,
        Card = 2,
        Electronic = 3,
        Fiche = 4,
        Film = 5,
        Magazine = 6,
        Manuscript = 7,
        Map = 8,
        Newspaper = 9,
        Photo = 10,
        Tombstone = 11,
        Video = 12,
    }
}

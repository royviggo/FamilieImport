﻿using FamilieImport.Gedcom.Models;
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
        public GedcomId Submitter { get; set; }
        public GedcomId Submission { get; set; }
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
        public GedcomId Id { get; set; }
        public RestrictionNotice RestrictionNotice { get; set; }
        public FamilyEventStructure FamilyEvent { get; set; }
        public GedcomId Husband { get; set; }
        public GedcomId Wife { get; set; }
        public GedcomId Child { get; set; }
        public int CountOfChildren { get; set; }
        public GedcomId Submitter { get; set; }
        public string UserReferenceNumber { get; set; }
        public string UserReferenceType { get; set; }
        public string AutomatedRecordId { get; set; }
        public ChangeDate ChangeDate { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
        public ICollection<SourceCitation> SourceCitations { get; set; }
        public ICollection<MultimediaLink> MultimediaLinks { get; set; }
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
        public GedcomId Individual { get; set; }
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
        public GedcomId Family { get; set; }
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
        public GedcomId Family { get; set; }
        public string AdoptedByWhichParent { get; set; }
    }

    public class MultimediaLink
    {
        public GedcomId Multimedia { get; set; }
        public string File { get; set; }
        public MultimediaFormat Format { get; set; }
        public SourceMediaType MediaType { get; set; }
        public string Title { get; set; }
    }

    public class NoteStructure
    {
        public GedcomId Source { get; set; }
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

    public enum RestrictionNotice
    {
        Confidential = 0, 
        Locked = 1, 
        Privacy = 2,
    }

    public class SourceCitation
    {
        public GedcomId Source { get; set; }
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
        public GedcomId Repository { get; set; }
        public NoteStructure NoteStructure { get; set; }
        public string CallNumber { get; set; }
        public SourceMediaType SourceMediaType { get; set; }
    }

    public class SpouseToFamilyLink
    {
        public GedcomId Family { get; set; }
        public ICollection<NoteStructure> Notes { get; set; }
    }

    public enum CharacterSet
    {
        Ansel = 0,
        Utf8 = 1, 
        Unicode = 2,
        Ascii = 3,
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

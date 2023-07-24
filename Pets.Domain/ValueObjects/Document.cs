using Pets.Domain.Enums;

namespace Pets.Domain.ValueObjects
{
    public struct Document
    {
        public Document(string documentNumber, EDocumentType documentType)
        {
            DocumentNumber = documentNumber;
            DocumentType = documentType;
        }
        public string DocumentNumber { get; private set; }
        public EDocumentType DocumentType { get; private set; }
    }
}
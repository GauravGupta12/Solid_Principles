using System;
namespace Solid_Principles
{
    // Interface Segregation Principle
    // segregate various print operartions in appropriate interfaces --> promotes scalability and code maintainability

    public interface IPrintScanContent
    {
        // print-scan related operations
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotocopyContent(string content);
    }

    public interface IFaxContent
    {
        // fax related operations
        bool FaxContent(string content);
    }

    public interface IPrintDuplexContent
    {
        // print duplex related operations 
        bool PrintDuplexContent();
    }
}
// Open Closed Principle
// If not followed --. following repercussions 
// 1. if a class always allows the addition of new logic, we end up testing the entire functionality along 
// with the requirement
// 2. breaks the single responsibilty principle
// 3. increases maintenance overhead

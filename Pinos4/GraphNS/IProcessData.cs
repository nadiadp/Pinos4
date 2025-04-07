/********************************************************************
*** NAME : IProcessData.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : Interface for data processing operations.
********************************************************************/

namespace GraphNS
{
    public interface IProcessData
    {
        /********************************************************************
        *** METHOD ReadData ***
        *********************************************************************
        *** DESCRIPTION : Reads graph data from specified path.
        *** INPUT ARGS : path - File path to read from
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        void ReadData(string path);
    }
}
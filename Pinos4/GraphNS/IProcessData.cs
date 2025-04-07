/********************************************************************
*** NAME : IProcessData.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This file defines the IProcessData interface which ***
*** specifies the contract for classes that need to read data from storage. ***
********************************************************************/

namespace GraphNS
{
    public interface IProcessData
    {
        /********************************************************************
        *** METHOD ReadData ***
        *********************************************************************
        *** DESCRIPTION : Reads data from the specified path. ***
        *** INPUT ARGS : path ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : void ***
        ********************************************************************/
        void ReadData(string path);
    }
}
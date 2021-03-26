open System


type OS = 
    {   
        Name: string; 
        Failure: int 
    }

type Computer = 
    { 
        OS: OS;
        mutable isInfected: bool 
    }

type Network(computers : list<Computer>, matrix : bool[,]) =
    let r = Random()

let listOfComputers = [{ OS =  {Name = "Windows"; Failure = 3 };  
                                            isInfected = true }; 
                    { OS = {Name = "OSX"; Failure = 2 };  
                                            isInfected = false }; 
                    { OS = {Name = "Ubuntu"; Failure = 1 } ;  
                                            isInfected = false }]

let matrix : bool[,] = Array2D.zeroCreate 3 3
matrix.[0,1] <- true;
matrix.[1,2] <- true;

let network = Network(listOfComputers, matrix)

printfn "%A\n %A" listOfComputers matrix
namespace EventManager
{
    class OperationsManager
    {
        public IOperations.Operations operation {get;set;}
        public int personID {get;set;}
        public string name {get;set;}
        public string surname {get;set;}
        public string company {get;set;}
        public string accessnumber {get;set;}
        public string table {get;set;}


        public OperationsManager(int personID,
                                string name,
                                string surname,
                                string company,
                                string accessNumber,
                                string table,
                                IOperations.Operations operation)
        {
            this.personID = personID;
            this.name = name;
            this.company = company;
            this.accessnumber = accessNumber;
            this.table = table;
            this.operation = operation;
        }

        public OperationsManager(string name,
                                string surname,
                                string company,
                                string accessNumber,
                                string table,
                                IOperations.Operations operation)
        {
            this.name = name;
            this.company = company;
            this.accessnumber = accessNumber;
            this.table = table;
            this.operation = operation;
        }
    }
}
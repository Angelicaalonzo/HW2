using System;

class tDate{
        public string earliestDate = "1/1/1900"; 
        public string LatestDate= "12/31/2100";
        public int day; 
        public int month; 
        public int year; 
        public int _month;
        public int _day;
        public int _year;
        

    public tDate(int month, int day, int year)
    {

        if((month > 0 && month<= 12) &&(day> 0 && day <=31) && (year>0) ){
                
        
         _month = month; 
          _day = day;
         _year = year;

        }
        else
        {
            String[] splitEarly = earliestDate.Split('/');
            month = int.Parse(splitEarly[0]);
            day = int.Parse(splitEarly[1]);
            year = int.Parse(splitEarly[2]);
        }

    }

    

    public tDate(string date)
    {
        date.Split('/');
        string[] dateComp = date.Split('/');
        month = int.Parse(dateComp[0]);
        day = int.Parse(dateComp[1]);
        year = int.Parse(dateComp[2]);

    if((month > 0 && month<= 12) &&(day> 0 && day <=31) && (year > 0) ){

        _month = month; 
        _day = day; 
        _year = year;
        

    }
    else{

         String[] splitEarly = earliestDate.Split('/');
            _month = int.Parse(splitEarly[0]);
            _day = int.Parse(splitEarly[1]);
            _year = int.Parse(splitEarly[2]);

            



    }

    }
    public void showDate(char f)
    {

        switch(f)
            {
            // //US Date
             case 'U':
            
             Console.WriteLine("{0},{1},{2}",_month, _day, _year);
             break;

             //EU Date
            case 'E':
            Console.WriteLine("{0},{1},{2}",_day, _month, _year);

             break;

        }

    }
}


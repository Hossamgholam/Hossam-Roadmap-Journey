bool date1_equel_date2(stdate date1,stdate date2){
    /*
    if(date1.year==date2.year){
        short number_of_day1=number_day_biging_date(date1.year,date1.monthe,date1.day);
        short number_of_day2=number_day_biging_date(date2.year,date2.monthe,date2.day);
        if(number_of_day1=number_of_day2){
            return true;
        }
        else{
            return false;
        }
    }
   
    else{
        return false;
    }
    */
   return (date1.year=date2.year?(date1.monthe==date2.monthe?(date1.day==date2.day?true:false):false):false);
}
#include <iostream>
#include "clsDate.h"
#include "clsString.h"
#include "clsPeriod.h"

using namespace std;
int main()
{
    clsDate date1;
    date1.print();

    clsDate date2("2/3/2025");
    date2.print();

    clsDate date3(12, 6, 2004);
    date3.print();

    clsDate date4(33, 2025);
    date4.print();

    //cout << date1.isLeapYear();
    //cout

    ////nubmer of day hour minutes seconde
    //cout << date1.numberOfDayInYear();
    //cout << endl;
    //cout << date1.numberOfHourInYear();
    //cout << endl;
    //cout << date1.numberOfMinutesInYear();
    //cout << endl;
    //cout << date1.numberOfSecondInYear();
    //cout << "\n\n\n\n";
    ////nubmer of day hour minutes seconde in monthe
    //cout << date1.numberOfDaysInMonthe();
    //cout << endl;
    //cout << date1.numberOfHourInMonthe();
    //cout << endl;
    //cout << date1.numberOfMinutesInMonthe();
    //cout << endl;
    //cout << date1.numberOfSecondInMonthe();
    //cout << "\n\n\n";
    ////day order in weak and short name
    //cout << date1.dayOfWeakOrder();
    //cout << endl;
    //cout << date1.dayShortName(date1.dayOfWeakOrder());
    //cout << endl;
    //cout << date1.dayShortName();
    //cout << "\n\n\n";
    ////monthe and year calender

    //date1.printMontheCalender();
    //cout << endl << endl;
    //date1.printYearCalendar();

    //cout << "\n\n\n";
    //cout << "days form begining year:";
    //int daysfrombeginingofYear= date1.daysFrombeginingOfYear();
    //cout << daysfrombeginingofYear << endl;
    //cout << "date from order in year:";
    //// it is static fuction but you can call from object
    //date1= date1.getDateFromOrderInYear(daysfrombeginingofYear, 2025);
    //date1.print();

    //cout << "\n\n\n";
    //cout << "is current date1 is befro date2;"
    //    << date2.isDate1BeforeDate2(date1) << endl;
    //cout << "is current date1 is equal to date2 : "
    //    << date2.isDate1EquelDate2(date1) << endl;
    //cout << "\n\n\n"; << endl;


    //cout << "is last day in monthe:" << date1.isLastDayInMonthe() << endl;
    //cout << "is last day in yearr:" << date1.isLastMontheInYear();

    /*
    date1 = date1.addOneDay();
    cout << "current date after add one date:"; date1.print();*/


    //cout << "my age in day is :" << clsDate::calculateMyAgeInDays(date3);

    /*
    ////////increrase date
    ////cout << "\n\n\n";
    ////cout << "after X day:";
    ////date1.increaseDateByXDay(3);
    ////date1.print(); cout << endl;

    ////cout << "after one week:";
    ////date1.increaseDateByOneWeak();
    ////date1.print(); cout << endl;

    ////cout << "after x week:";
    ////date1.increaseDateByXWeak(1);
    ////date1.print(); cout << endl;

    ////cout << "after one monthe:";
    ////date1.increaseDateByOneMonthe();
    ////date1.print(); cout << endl;

    ////cout << "after add X monthe:";
    ////date1.increaseDateByXMonthe(1);
    ////date1.print(); cout << endl;

    ////cout << "after add one year:";
    ////date1.increaseDateByOneYear();
    ////date1.print();cout << endl;

    ////cout << "after add XYear:";
    ////date1.increaseDateByXYear(1);
    ////date1.print(); cout << endl;

    ////cout << "after add OneDecade:";
    ////date1.increaseDateByOneDecade();
    ////date1.print(); cout << endl;

    ////cout << "after add XDecade:";
    ////date1.increaseDateByXDecade(1);
    ////date1.print(); cout << endl;

    ////cout << "after add Century:";
    ////date1.increaseDateByCentury();
    ////date1.print(); cout << endl;

    ////cout << "after add millennium:";
    ////date1.increaseDateBymillennium();
    ////date1.print(); cout << endl;

    ////cout << "after decrease oneday:";
    ////date1.DecreaseOneDay();
    ////date1.print(); cout << endl;

    ////cout << "after decrease xday:";
    ////date1.DecreaseXDay(3);
    ////date1.print(); cout << endl;

    ////cout << "after decrease one week:";
    ////date1.DecreaseOneWeake();
    ////date1.print(); cout << endl;

    ////cout << "after decrease x week:";
    ////date1.DecreaseXWeake(1);
    ////date1.print(); cout << endl;

    ////cout << "after decrease OneMonthe:";
    ////date1.DecreaseOneMonthe();
    ////date1.print(); cout << endl;

    ////cout << "after decrease x week:";
    ////date1.DecreaseXMonthe(1);
    ////date1.print(); cout << endl;

    ////cout << "after decrease OneYear:";
    ////date1.DecreaseOneYear();
    ////date1.print(); cout << endl;

    ////cout << "after decrease XYear:";
    ////date1.DecreaseXYear(1);
    ////date1.print(); cout << endl;

    ////cout << "after decrease OneDecade:";
    ////date1.DecreaseOneDecade();
    ////date1.print(); cout << endl;

    ////cout << "after decrease XDecade:";
    ////date1.DecreaseXDecade(1);
    ////date1.print(); cout << endl;

    ////cout << "after decrease Century:";
    ////date1.DecreaseCentury();
    ////date1.print(); cout << endl;

    ////cout << "after decrease millennium:";
    ////date1.Decreasemillennium();
    ////date1.print(); cout << endl;
    */


    /*
     //cout << "\n\n\n";
     //cout << "number of day in year:" << date1.numberOfDayInYear();
     //cout << endl;
     //cout << "the day beging of year:" << date1.daysFrombeginingOfYear();
     //cout << endl;
     //cout << "the day until end of year:" << date1.DaysUntilTheEndOfYear();
     //cout << endl;

     //cout << "number of day in monthe:" << date1.numberOfDaysInMonthe(); cout << endl;
     //cout << "number of day until end of month:" << date1.DaysUntilTheEndOfMonthe();
     */

     //get and set without call function
    clsPeriod p;
    p.startDate = clsDate(3, 3, 3);
    cout << "\n\n";
    p.endDate.print();
    cout << "\n";
     p.print();




}



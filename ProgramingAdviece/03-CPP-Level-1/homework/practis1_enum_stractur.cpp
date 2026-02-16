#include<iostream>
using namespace std;
/*
encolor
engender
enmaritalstaus

staddress(streetname,bulidingno,pobx,zipcode)
stcontactinfo(phone,email,address)
stperson(fristname,lastname,stcontactinfo,encolor,ingender,enmaritalstatus)
*/
enum encolor{red=1,blue=2,black=3,yello=4};
enum engender{male=1,female=2};
enum enmaritalstatus{single=1,marride=2};

struct staddress{
    string streetname;
    string bulidingno;
    string pobx;
    string zipcode;
};
struct stcontactinfo{
    string phone;
    string emaile;
    staddress address;
};
struct stperson{
    string fristname;
    string lastname;
    stcontactinfo contactinfo;
    encolor  color;
    engender  gender;
    enmaritalstatus maritalstatus;
};
int main(){
    stperson p1;

    p1.fristname="hossam";
    p1.lastname="gholam";
    p1.contactinfo.phone="01021832326";
    p1.contactinfo.emaile="hossamgholam1234@gmail.com";
    p1.contactinfo.address.streetname="komelnegare";
    p1.contactinfo.address.bulidingno="23232";
    p1.contactinfo.address.pobx="sldjfl";
    p1.contactinfo.address.zipcode="23k2l3";
    p1.color=encolor::black;
    p1.  gender=engender::male;
    p1. maritalstatus=enmaritalstatus::single;

    cout<<"your maritalstatus is :"<<p1.maritalstatus<<endl;
    cout<<"your color is:"<<p1.color;
    

    
}
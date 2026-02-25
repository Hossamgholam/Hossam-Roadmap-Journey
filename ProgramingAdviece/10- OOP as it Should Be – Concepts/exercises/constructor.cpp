#include<iostream>
using namespace std;
class ClsAddress{
    private:
    string _Addressline1;
    string _AddressLine2;
    string _PoBox;
    string _ZipCode;

    

    public:
    ClsAddress(){
        _Addressline1="bassion";
        _AddressLine2="tanta";
        _PoBox="2222";
        _ZipCode="12";
        cout<<"hello iam default constractor\n";
    }
    ClsAddress(string AddressLine1,string AddressLine2,string PoBox,string ZipCode){
        _Addressline1=AddressLine1;
        _AddressLine2=AddressLine2;
        _PoBox=PoBox;
        _ZipCode=ZipCode;
        cout<<"hello iam paramter constractor\n";
    }
    ClsAddress(ClsAddress& Old_object){
        _Addressline1=Old_object.GetAddressLine1();
        _AddressLine2=Old_object.GetAddressLine2();
        _PoBox=Old_object.GetPoBox();
        _ZipCode=Old_object.GetZipCode();
        cout<<"hello i am copy constractro\n";

    }
    
    ~ClsAddress(){
        cout<<"iam destractor\n";
    }
    //copy constructor

    void SetAddressLine1(string Addressline1){
        _Addressline1=Addressline1;
    }
    string GetAddressLine1(){
        return _Addressline1;
    }
    void SetAddressLine2(string Addressline2){
        _AddressLine2=Addressline2;
    }
    string GetAddressLine2(){
        return _AddressLine2;
    }
    void SetPoBox(string PoBox){
        _PoBox=PoBox;
    }
    string GetPoBox(){
        return _PoBox;
    }
    void SetZipCode(string ZipCode){
        _ZipCode=ZipCode;
    }
    string GetZipCode(){
        return _ZipCode;
    }
    void PrintAddress(){
        cout<<"***************************************\n";
        cout<<"          your Address                 \n";
        cout<<"***************************************\n";
        cout<<"AddressLine1:"<<_Addressline1<<endl;
        cout<<"AddressLine2:"<<_AddressLine2<<endl;
        cout<<"PoBox       :"<<_PoBox<<endl;
        cout<<"ZipCode     :"<<_ZipCode<<endl;
    }
};

void fun1(){
    ClsAddress a1;
}

void fun2(){
    ClsAddress* add=new ClsAddress;
    delete add;
}
int main(){
    /*
    ClsAddress addres1;
    addres1.PrintAddress();

    ClsAddress addres11("tanta","egypt","23","k3");
    addres11.PrintAddress();

    ClsAddress addres2=addres1;
    addres2.PrintAddress();
    */
   fun1();
   fun2();












































}
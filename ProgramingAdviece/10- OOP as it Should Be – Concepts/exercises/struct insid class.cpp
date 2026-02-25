#include<iostream>
using namespace std;
class ClsPerson {
    public:
        struct stdAddress{
            string addressLineOne;
            string addressLineTwo;
            string city;
            string counter;
        };
    private:
        int _id;
        string _fristname;
        string _lastname;
        string _email;
        string _phone;
        stdAddress _address;
    
    
    
    
    
    public:
        
        ClsPerson(int id, string fristName, string lastName, string email, string phone
            ,string addresslineone,string addresslineto,string city,string counter) {
            _id = id;
            _fristname = fristName;
            _lastname = lastName;
            _email= email;
            _phone = phone;
            _address.addressLineOne=addresslineone;
            _address.addressLineTwo=addresslineto;
            _address.city=city;
            _address.counter=counter;
        }
        ClsPerson() {
    
        }
        
        ClsPerson(ClsPerson& oldObject){
            _id=oldObject._id;
            _fristname=oldObject._fristname;
            _lastname=oldObject._lastname;
            _email=oldObject._email;
            _phone=oldObject._phone;
            _address=oldObject._address;
        }
        
        void setId(int id) {
            _id = id;
        }
        int getId() {
            return _id;
        }
    
        void setFristName(string fristName) {
            _fristname = fristName;
        }
        string getFristName() {
            return _fristname;
        }
        
        void setLastName(string lastName) {
            _lastname = lastName;
        }
        string getlastName() {
            return _lastname;
        }
    
        void setEmail(string email) {
            _email = email;
        }
        string getEmail() {
            return _email;
        }
    
        void setPhone(string phone) {
            _phone = phone;
        }
        string getPhone() {
            return _phone;
        }

        void setAddress(string addresslineone,string addresslineto,string city,string counter){
            _address.addressLineOne=addresslineone;
            _address.addressLineTwo=addresslineto;
            _address.city=city;
            _address.counter=counter;
        }
        stdAddress getAddress(){
            return _address;
        }
        
        string fullName() {
            return _fristname + " "+_lastname;
        }
       
        void print() {
            cout << "             info                    \n";
            cout << "_____________________________________\n";
            cout << "Id          : " << _id << endl;
            cout << "fristName   :" << _fristname << endl;
            cout << "lastName    :" << _lastname << endl;
            cout << "fullName    :" << fullName() << endl;
            cout << "email       :" << _email << endl;
            cout << "phone       :" << _phone << endl;
            cout<<"addresslineOne:"<<_address.addressLineOne<<endl;
            cout<<"addresslineTwo:"<<_address.addressLineTwo<<endl;
            cout<<"city          :"<<_address.city<<endl;
            cout<<"countery      :"<<_address.counter<<endl;
            cout << "______________________________________\n\n";
        }
    
        void sendEmail(string subject, string body) {
            cout << "the fllowing message sent to this email:" << _email << endl;
            cout << "subject:" << subject << endl;
            cout << "body :" << body << endl << endl;
        }
    
        void sendMassage(string message) {
            cout << "the following sms send to this phone:" << _phone << endl;
            cout << message;
        }
    };
    int main(){
        //withe constran
        ClsPerson hossam(1,"hossam","gholam","hossam1234@gmail.com","01021832326","komalngar","bassion","tanta","egypt");
        hossam.print();

        ///withe get and set

        hossam.setAddress("koko","bass","dkkk","dd");
        ClsPerson::stdAddress addres=hossam.getAddress();
        cout<<"hello "<<hossam.getFristName()<<endl;
        cout<<"your addres is :"<<addres.addressLineOne;


        ClsPerson ali=hossam;
        ali.print();
    }
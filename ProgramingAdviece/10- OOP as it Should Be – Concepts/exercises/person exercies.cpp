
#include <iostream>
#include<vector>
using namespace std;
class ClsPerson {
private:
    int _id;
    string _fristname;
    string _lastname;
    string _email;
    string _phone;
    
    
public:
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

    
    string fullName() {
        return _fristname + " "+_lastname;
    }
   
    ClsPerson(int id, string fristName, string lastName, string email, string phone) {
        _id = id;
        _fristname = fristName;
        _lastname = lastName;
        _email= email;
        _phone = phone;
        

    }
    ClsPerson() {

    }
    void print() {
        cout << "             info                    \n";
        cout << "_____________________________________\n";
        cout << "Id        : " << _id << endl;
        cout << "fristName :" << _fristname << endl;
        cout << "lastName  :" << _lastname << endl;
        cout << "fullName  :" << fullName() << endl;
        cout << "email     :" << _email << endl;
        cout << "phone     :" << _phone << endl;
        
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
class clsEmployee:public ClsPerson {
    string _title;
    float _salary;
    string _department;
public:
    clsEmployee() {

    }
    clsEmployee(int id, string fristName, string lastName, string email, string phone,string title,float salary,string department)
        :ClsPerson(id, fristName, lastName, email, phone) {
        
        _title = title;
        _salary = salary;
        _department = department;
    }
    void setTitle(string title) {
        _title = title;
    }
    string getTitle() {
        return _title;
    }

    void setSalary(float salary) {
        _salary = salary;
    }
    float getSalary() {
        return _salary;
    }

    void setDepartment(string Department) {
        _department = Department;
    }
    string getDepartment() {
        return _department;
    }
    void print() {
        
        cout << "             info                    \n";
        cout << "_____________________________________\n";
        cout << "Id        : " <<getId ()<<endl;
        cout << "fristName :" << getFristName() << endl;
        cout << "lastName  :" <<getlastName() << endl;
        cout << "fullName  :" << fullName() << endl;
        cout << "email     :" << getEmail() << endl;
        cout << "phone     :" << getPhone() << endl;
        cout << "title     :" << _title << endl;
        cout << "salary    :" << _salary << endl;
        cout << "department:" << _department << endl;

        cout << "______________________________________\n\n";
    }
};

class clsProgramer:public clsEmployee {
private:
    string _mainProgramingLanguge;
public:
    clsProgramer(int id, string fristName, string lastName, string email, string phone, string title
        , float salary, string department, string programingLanguage) :clsEmployee(id, fristName, lastName, email, phone, title, salary, department) {
        _mainProgramingLanguge = programingLanguage;
    }
    clsProgramer() {

    }
    
    void setProgramingLanguge(string progamingLanguge) {
        _mainProgramingLanguge = progamingLanguge;
    }
    string getProgramingLanguage() {
        return _mainProgramingLanguge;
    }

    void print() {
        cout << "             info                    \n";
        cout << "_____________________________________\n";
        cout << "Id            : " << getId() << endl;
        cout << "fristName     :" << getFristName() << endl;
        cout << "lastName      :" << getlastName() << endl;
        cout << "fullName      :" << fullName() << endl;
        cout << "email         :" << getEmail() << endl;
        cout << "phone         :" << getPhone() << endl;
        cout << "title         :" << getTitle() << endl;
        cout << "salary        :" << getSalary() << endl;
        cout << "department    :" << getDepartment() << endl;
        cout << "programlanguge:" << _mainProgramingLanguge << endl;

        cout << "______________________________________\n\n";
    }
};

ClsPerson readInfo() {
    

    int _id;
    string _fristname;
    string _lastname;
    string _email;
    string _phone;
    
    cout << "please inter your id        :";cin>>_id;
    cout << "please inter your frist name:"; cin >> _fristname;
    cout << "please inter your last name :"; cin >> _lastname;
    cout << "please inter your email     :"; cin >> _email;
    cout << "please inter your phone     :"; cin >> _phone;
    cout << "\n\n";
    ClsPerson a(_id, _fristname, _lastname, _email, _phone);
    return a;
}

int main()
{
   /* ClsPerson a(10, "hossam", "gholam", "hossam1234@gmial.com", "010218");
    a.print();
    a.sendEmail("hi", "how are you?");
    a.sendMassage("how are your:");
    
    cout << "\n\n\n";
    clsEmployee ap(2, "ali", "gholam", "laiid23@gmail.com", "03000000", "eng", 40000, "t");
    ap.print();

    cout << "\n\n\n";
    clsProgramer aaa(3, "hossam", "gholam", "hossam1234@gmial.com", "010218","eng", 40000, "t", "cpp");
    aaa.print();*/

    //cascating////
    //ClsPerson q(2, "mahmod", "ashor", "alss12@gmial.com", "01110111");
    //clsEmployee a(2, "ali", "gholam", "laiid23@gmail.com", "03000000", "eng", 40000, "t");
    //clsProgramer w(3, "hossam", "gholam", "hossam1234@gmial.com", "010218", "eng", 40000, "t", "cpp");
    //
    //

    //ClsPerson* p;
    //clsEmployee* s;
    //clsProgramer* d;
    //    
    //p=&a;
    //p->print();
    //p->sendEmail("fuck","fuck you ");
   
    //

    //s=&w;
    //s->print();
    //s->sendEmail("hello", "welcom to my compain");

    /*
    vector<ClsPerson> storge;
    
    for (int i = 0; i < 3; i++) {
        storge.push_back(readInfo());
    }

    for (int i = 0; i < 3; i++) {
        storge[i].print();
        cout << "\n\n\n";
    }

    for (int i = 0; i < 3; i++) {
        if (storge[i].getFristName() =="hossam") {
            storge[i].sendEmail("jop", "it is work");
        }
    }*/

    /*short size;
    cout << "please inter size:"; cin >> size;
    ClsPerson* arr = new ClsPerson[size];

    for (int i = 0; i < size; i++) {
        arr[i] = readInfo();
    }
    for (int i = 0; i < size; i++) {
       
        arr[i].sendEmail("work", "we need you");
    }*/

    /*
    
    clsEmployee arryEmployee[] = {
        clsEmployee(2, "hossam", "gholam", "hossam1234@gmail.com", "03000000", "eng", 40000, "t")
        ,clsEmployee(3, "ali", "gholam", "laiid23@gmail.com", "03000000", "eng", 40000, "t")
    };
    int number= sizeof(arryEmployee)/sizeof(clsEmployee);

    for (int i = 0; i < number; i++) {
        if (arryEmployee[i].getId() == 2) {
            arryEmployee[i].print();
        }
        else {
           cout<< arryEmployee[i].getDepartment();
        }
    }
    */
        //ClsPerson q(2, "mahmod", "ashor", "alss12@gmial.com", "01110111");
    //clsEmployee a(2, "ali", "gholam", "laiid23@gmail.com", "03000000", "eng", 40000, "t");
    //clsProgramer w(3, "hossam", "gholam", "hossam1234@gmial.com", "010218", "eng", 40000, "t", "cpp");
    //
    //
    ClsPerson q(2, "mahmod", "ashor", "alss12@gmial.com", "01110111");
    clsEmployee a(2, "ali", "gholam", "laiid23@gmail.com", "03000000", "eng", 40000, "t");
    clsProgramer w(3, "hossam", "gholam", "hossam1234@gmial.com", "010218", "eng", 40000, "t", "cpp");
    
    
    ClsPerson* p;
    clsEmployee* s;
    clsProgramer* d;
        
    p=&a;
    p->print();
   
   
}


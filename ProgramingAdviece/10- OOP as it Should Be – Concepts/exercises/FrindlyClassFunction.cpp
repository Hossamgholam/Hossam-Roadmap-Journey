
#include<iostream>
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
        return _fristname + " " + _lastname;
    }

    ClsPerson(int id, string fristName, string lastName, string email, string phone) {
        _id = id;
        _fristname = fristName;
        _lastname = lastName;
        _email = email;
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

    friend class clsEmployee;
    friend void logIn();

};
class clsEmployee {
    string _title;
    float _salary;
    string _department;
public:

    clsEmployee() {

    }
    clsEmployee(string title, float salary, string department)
    {

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
    void print(ClsPerson a) {

        cout << "             info                    \n";
        cout << "_____________________________________\n";
        cout << "Id        : " << a._id << endl;
        cout << "fristName :" << a._fristname << endl;
        cout << "lastName  :" << a._lastname << endl;
        cout << "fullName  :" << a.fullName() << endl;
        cout << "email     :" << a._email << endl;
        cout << "phone     :" << a._phone << endl;
        cout << "title     :" << _title << endl;
        cout << "salary    :" << _salary << endl;
        cout << "department:" << _department << endl;

        cout << "______________________________________\n\n";
    }
    //__declspec(property(get = getTitle, put = setTitle))string _title;
    //__declspec(property(get = getSalary, put =setSalary))float _salary;
    //__declspec(property(get = getDepartment, put = setDepartment))string _department;

    friend void logIn();
};

void logIn() {

    string typeChoess;
    cout << "do you want to add person or employee:"; cin >> typeChoess;
    if (typeChoess == "employee") {
        ClsPerson p1(1, "hossam", "gholam", "hossamgholam1234@gmail.com", "01021832326");;
        clsEmployee  e1("enginerring", 100000, "is");
        /*i know you can use get and set funtion but to achivee friend fuction*/
        cout << "hello en:" << p1._fristname + p1._lastname << " your id is " << p1._id
            << " your email is " << p1._email << " and your phone " << p1._phone << endl
            << " your salary is:" << e1._salary;
    }
}
int main() {
    logIn();
}
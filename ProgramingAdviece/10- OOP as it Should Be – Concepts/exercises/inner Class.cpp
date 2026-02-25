
#include <iostream>
using namespace std;

class clsPerson {
public:
    /// <summary>
    /// make it public for own reason
    /// if i want to declaration object in main for
    /// fuction getAddres()
    /// </summary>
    class clsAddress {
        string _addressOne;
        string _addressTwo;
        string _city;
        string _country;

    public:
        clsAddress(string addressone, string addressTwo, string city,string country) {
            _addressOne = addressone;
            _addressTwo = addressTwo;
            _city = city;
            _country = country;
        }
       

        void setAddressOne(string addressOne) {
            _addressOne = addressOne;
        }
        string getaAddressOne() {
            return _addressOne;
        }

        void setAddressTwo(string addressTwo) {
            _addressTwo = addressTwo;
        }
        string getaAddressTwo() {
            return _addressTwo;
        }

        void setCity(string city) {
            _city = city;
        }
        string getCity() {
            return _city;
        }

        void setCountry(string country) {
            _country = country;
        }
        string getCountry() {
            return _country;
        }

        void printAddress() {
            cout << "_________________________________________\n\n";
            cout << "addresslineOne:" << _addressOne << endl;
            cout << "addresslineTwo:" << _addressTwo << endl;
            cout << "city          :" << _city << endl;
            cout << "countery      :" << _country << endl;
            cout << "______________________________________\n\n";
        }
    };
private:
    string _fullName;
    //clsAddress address = clsAddress("", "", "", "");
    clsAddress _address;
public:
    
    clsPerson(string fullName, string addressOne, string addressTwo, string city, string country)
        :_address(addressOne,addressTwo,city,country)
    {
        _fullName = fullName;
        //address = clsAddress(addressOne, addressTwo, city, country);
    }
    
    void setFullName(string name) {
        _fullName = name;
    }
    string getFullName() {
        return _fullName;
    }

    void setAddress(clsAddress newAddress) {
        _address = newAddress;
    }
    clsAddress getAddress() {
        return _address;
    }
    
    void print() {
        cout << "             info                    \n";
        cout << "_____________________________________\n";
        cout << "full name :" << _fullName << endl;
        cout << "addresslineOne:" << _address.getaAddressOne() << endl;
        cout << "addresslineTwo:" << _address.getaAddressTwo() << endl;
        cout << "city          :" << _address.getCity() << endl;
        cout << "countery      :" << _address.getCountry() << endl;
        cout << "______________________________________\n\n";
    }

};

int main()
{
    clsPerson p1("hossam","aa","aa","dd","dd");
    p1.print();
    
    //for function getAddress() in clsPerson
    clsPerson::clsAddress addres = p1.getAddress();
    addres.printAddress();

    //indepent class address
    clsPerson::clsAddress newaddress("sss", "ds", "ds", "ss");
    newaddress.printAddress();

}


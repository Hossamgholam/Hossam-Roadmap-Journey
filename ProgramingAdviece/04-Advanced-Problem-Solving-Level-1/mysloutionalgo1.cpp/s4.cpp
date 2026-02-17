#include<iostream>
using namespace std;

/*

void read_info(short &age,bool &driver_license){
   cout<<"please inter your age: ";cin>>age;
   cout<<"please inter your driver_license:";cin>>driver_license;
}
string driver(short age,bool driver_license){
    if((age>21)&&(driver_license==1)){
    return"hired";
   }
   else{
    return"rejecst";
   }
}
*/

struct st_driverinfo{
   short age;
   bool has_driver_license;
};


st_driverinfo read_info(){
   st_driverinfo driver1;
   cout<<"please inter driver age:";cin>>driver1.age;
   cout<<"please inter if drever has license:";cin>>driver1.has_driver_license;
   return driver1;

}

bool isaccepted(st_driverinfo driver_info){
    if((driver_info.age>21)&&(driver_info.has_driver_license==1)){
    return true;
   }
   else{
    return false;
   }
}

void print_result(bool your_result){
        if(your_result==true){
         cout<<"hired\n";
        }
        else{
         cout<<"rejected\n";
        }
}


int main(){
   
  print_result(isaccepted(read_info()));
}
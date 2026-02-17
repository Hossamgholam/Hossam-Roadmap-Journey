#include<iostream>
using namespace std;
/*

void read_info(short &your_age,bool &your_driver_license,bool &your_recomndation){
   cout<<"please inter your age: ";cin>>your_age;
   cout<<"please inter your driver_license:";cin>>your_driver_license;
   cout<<"please inter if you have recomndation:";cin>>your_recomndation
}
string driver(short age,bool your_driver_license,bool your_recomndation){
    if(your_recomndation==1){
    return"hired";
   }
   else{
    if((age>21)&&(driver_license==1)){
        return "hired";
    }
    else{
        return "reject";
    }
   }
}

*/

struct st_driverinfo{
   short age;
   bool has_driver_license;
   bool recomandation;
};


st_driverinfo read_info(){
   st_driverinfo driver1;
   cout<<"please inter driver age:";cin>>driver1.age;
   cout<<"please inter if drever has license:";cin>>driver1.has_driver_license;
   cout<<"please inter if you have rcomandtion:";cin>>driver1.recomandation;
   return driver1;

}

bool isaccepted(st_driverinfo driver_info){
    if(driver_info.recomandation==1){
        return true;
    }
    else{

         if((driver_info.age>21)&&(driver_info.has_driver_license==1)){
          return true;
         }
         else{
        return false;
         }
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
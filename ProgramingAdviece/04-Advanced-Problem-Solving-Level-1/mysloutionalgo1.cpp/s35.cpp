#include<iostream>
using namespace std;
struct st_piggybankcontant{
    float pennies,nickles ,dimes,quarters,dollars;
};
st_piggybankcontant read_number(){
    st_piggybankcontant your_piggybank;
   cout<<"please inter pennies:";cin>>your_piggybank.pennies ;
    cout<<"please inter nickles:";cin>>your_piggybank. nickles;
    cout<<"please inter dimes:";cin>>your_piggybank.dimes;
    cout<<"please inter quarters:";cin>>your_piggybank.quarters;
    cout<<"please interdollars: ";cin>>your_piggybank. dollars; 
    return your_piggybank;
}
int  calculat_total_pennies(st_piggybankcontant your_piggbank){
    return(your_piggbank.pennies+(your_piggbank.nickles*5)+(your_piggbank.dimes*10)+(your_piggbank.quarters*25)+(your_piggbank.dollars*100));
    
}


/*

int main(){
    float pennies,nickles,dimes,quarters,dollars;
    cout<<"please inter pennies:";cin>>pennies;
    cout<<"please inter nickles:";cin>>nickles;
    cout<<"please inter dimes:";cin>>dimes;
    cout<<"please inter quarters:";cin>>quarters;
    cout<<"please interdollars: ";cin>>dollars;

    float total_pennies=(pennies+(nickles*5)+(dimes*10)+(quarters*25)+(dollars*100));
    float total_doller=(total_pennies*100);
    cout<<"the total pennies is:"<<total_pennies<<"\n";
    cout<<"the total doller is:"<<total_doller<<"\n";
}
*/


int main(){
    int total_pennies=calculat_total_pennies(read_number());
    float total_dollars=(float) total_pennies/100;

    cout<<"the total pennies is :"<<total_pennies<<endl;
    cout<<"the total dollers is :"<<total_dollars;
    
}
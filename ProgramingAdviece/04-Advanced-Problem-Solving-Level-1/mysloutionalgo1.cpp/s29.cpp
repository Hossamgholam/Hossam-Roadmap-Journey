#include<iostream>
using namespace std;
enum enodd_even{even=1,odd=2};
int read_number(){
    int your_number;
    cout<<"please inter your number:";cin>>your_number;
    return your_number;
}

enodd_even check_number(int your_number) {
    if(your_number%2==0){
        return enodd_even::even;
    }
    else return enodd_even::odd;
}                              

int sum_odd_for(int your_number){
    int sum=0;
    for(int i=1;i<=your_number;i++){
        if(check_number(i)==enodd_even::even){
            sum+=i;
        }
        else{
            continue;
        }
    }
    return sum;
}
int sum_odd_while(int your_number){
    int sum=0,i=1;
    while(i<=your_number){
        if(check_number(i)==enodd_even::even){
            sum+=i;
        }
        
        i++;
    }
    return sum;
}
int sum_odd_dowhile(int your_number){
    int sum=0,i=1;
    do{
        if(check_number(i)==enodd_even::even){
            sum+=i;
        }
       
        i++;
    }while(i<=your_number);
    return sum;
}
void print_sum_odd(int your_sum){
    cout<<"the sum of even number is:"<<your_sum<<endl;
}
int main(){
   int number=read_number();
   print_sum_odd(sum_odd_for(number));
   print_sum_odd(sum_odd_while(number));
   print_sum_odd(sum_odd_dowhile(number));

}
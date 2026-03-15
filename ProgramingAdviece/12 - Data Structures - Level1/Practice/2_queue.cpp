#include<iostream>
#include<queue>
using namespace std;
int main(){

    #pragma region queue
        
    /*
    
    queue<string>quString;
    quString.push("hossam");
    quString.push("alsid");
    quString.push("salim");
    quString.push("alsid");
    quString.push("gholam");

    cout << "ths size is       :" << quString.size() << endl;
    cout << "the front emlement:" << quString.front() << endl;;
    cout << "the back end      :" << quString.back() << endl;

    while (!quString.empty()) {
        cout << quString.front()<<" ";
        quString.pop();
    }

    quString.push("hossam");
    quString.push("alsid");
    quString.push("salim");
    quString.push("alsid");
    quString.push("gholam");
    cout << endl;
    int size = quString.size();
    for (int i = 0; i < size; i++) {
        cout << quString.front() << "=";
        quString.pop();
    }
    */
        #pragma endregion


    queue<string> qstringName;
    queue<string>qSwap;

    string name;

    
    int size;
    cout<<"pleas inter size of queue :";cin>>size;
    for(int i=0;i<size;i++){
        cout<<"pleaser inter name:";cin>>name;
        qstringName.push(name);

    }

    int space;
    cout<<"pleas inter size of queue :";cin>>space;
    for(int i=0;i<space;i++){
        cout<<"pleaser inter name:";cin>>name;
        qSwap.push(name);
        
    }


    qstringName.swap(qSwap);
    
    cout<<"qustringname elment is : ";
    while(!qstringName.empty()){
        cout<<qstringName.front()<<" ";
        qstringName.pop();
    }
    
    cout<<endl<<endl;
    cout<<"quswap elment is : ";
    while(!qSwap.empty()){
        cout<<qSwap.front()<<" ";
        qSwap.pop();
    }


}

#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*
random number
full matrix 
print matrix
check 1 
check 0
check condation

*/
int random_number(int your_from,int your_to){
    return rand()%(your_to-your_from+1)+your_from;
}
void full_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            your_matrix[i][y]=random_number(1,10);
        }
    }
}

void print_matrix(int your_matrix[3][3],int row ,int colum){
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
        
            printf("%0*d\t",2,your_matrix[i][y]);
        }
        cout<<endl;
    }
}

bool scalar_matrix(int your_matrix[3][3],int row, int colum){
    int scal=your_matrix[0][0];
    for(int i=0;i<row;i++){
        for(int y=0;y<colum;y++){
            if(i==y&&your_matrix[i][y]!=scal){
                return false;
            }
            else if(i!=y&&your_matrix[i][y]!=0){
                return false;
            }
        }
    }
    return true;
}
int main(){
    int matrix[3][3]={{9,0,0},{0,9,0},{0,0,9}};
   // full_matrix(matrix,3,3);
    cout<<"this is matrix\n";
    print_matrix(matrix,3,3);

    if(scalar_matrix(matrix,3,3)){
        cout<<"the matrix is scalar\n";
    }
    else{
        cout<<"the matrix not scalar\n";
    }
}
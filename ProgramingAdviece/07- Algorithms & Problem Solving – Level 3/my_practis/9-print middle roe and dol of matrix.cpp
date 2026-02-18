#include<iostream>
#include<iomanip>
#include<ctime>
using namespace std;
/*


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
        if(your_matrix[i][y]<10){
            printf("%0*d\t",2,your_matrix[i][y]);
        }
        else{

               cout<<your_matrix[i][y]<<"\t";
        }
            
        }
        cout<<endl;
    }
}

int middel_number(int your_number){
    return your_number/2;
}

void print_middel_row(int your_matrix[3][3],int row,int colum){
    int middel_row=middel_number(row);
    for(int i=0;i<colum;i++){
        if(your_matrix[middel_row][i]<10){
            printf("%0*d\t",2,your_matrix[middel_row][i]);
        }
        else{

               cout<<your_matrix[middel_row][i]<<"\t";
        }
    }
}
void print_middel_colum(int your_matrix[3][3],int row,int colum){
    int middel_colum=middel_number(colum);
    for(int i=0;i<row;i++){
        if(your_matrix[i][middel_colum]<10){
            printf("%0*d\t",2,your_matrix[i][middel_colum]);
        }
        else{

               cout<<your_matrix[i][middel_colum]<<"\t";
        }
    }
}
int main(){
    int matrix[3][3];
    cout<<"this is random number matrix\n";
    full_matrix(matrix,3,3);
    print_matrix(matrix,3,3);
    cout<<"this is middel row\n";
    print_middel_row(matrix,3,3);
    cout<<"\nthis is middel colum\n";
    print_middel_colum(matrix,3,3);
}
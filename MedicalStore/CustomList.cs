using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class CustomList<Type>:IEnumerable,IEnumerator
    {
       private int _count=0;
        private int _capacity=4;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        Type[] List;
        
        public Type this[int index]{
            get {return List[index];}
            set {List[index]=value;}
        }

        
        public CustomList(){

            List=new Type[_capacity];

        }
        public CustomList(int size){

            _capacity=size;
            List=new Type[_capacity];

        }
        public void Add(Type value){

            if(_count==_capacity){
                Grow();
            }
            List[_count++]=value;
            
        }
        void Grow(){
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            int increase=0;
            foreach(Type i in List){
                temp[increase++]=i;
            }
            List=temp;
        }
        public void AddRange(CustomList<Type> arr){
            for(int i=0;i<arr._count;i++){
                 if(_count==_capacity){
                Grow();}
                List[_count++]=arr[i];
            }
        } 
        int position=-1;
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {   if(position<_count-1){
            position++;
            return true;
        }
            Reset();
            return false;
        }

        public void Reset()
        {
            position=-1;
        }
        public object Current{get {return List[position];}}
    }
}

interface IPatient:IGeneric<Patient>
{

    List<Patient> MedicineAll(int id);

}

interface IDoctor:IGeneric<Doctor>
{
    List<Doctor> DoctorByIdPatient(int id);
}

interface INurse: IGeneric<Nurse>
{

}


interface IGeneric<T>
{
    List<T> GetList();
    T Get(int id);
    void Update(T p);
    void Add(int id);
    void Delete(int id);
}


class Patient
{
    public int MyProperty { get; set; }
}
class Nurse
{
    public int MyProperty { get; set; }
}
class Doctor
{
    public int MyProperty { get; set; }
}


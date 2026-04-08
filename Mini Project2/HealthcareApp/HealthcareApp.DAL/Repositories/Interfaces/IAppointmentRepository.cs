using HealthcareApp.Entities.Models;

public interface IAppointmentRepository
{
    IEnumerable<Appointment> GetAll();

    Appointment GetById(int id);   

    void Add(Appointment appointment);

    void Update(Appointment appointment);
}
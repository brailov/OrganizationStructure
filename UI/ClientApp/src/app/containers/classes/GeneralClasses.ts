
export class ManagerDtos
{
  FirstName: string;
    LastName:  string;
    SubReports: Report[];
    MyEmployees: EmployeeDetailsDtos[];
}

export class EmployeeKey
{
  firstName: string;
  lastName: string;
  position: string;
}

export class EmployeeDetailsDtos
{
  FirstName: string;
  LastName: string;
  Position: string;
  assignedTasks: Task[];
}

export class Task
{
  text: string;
  assignDate: string;
  dueDate: string;
}

export class EmployeeTaskKey
{
  firstName: string;
  lastName: string;
  position: string;
  text: string;
  assignDate: string;
  dueDate: string;
}
export class Report {
  text: string;
  date: string;
}

export class MngrReportsDtos {
  MngrFirstName: string;
  MngrLastName: string;
  EmpFirstName: string;
  EmpLastName: string;
  EmpPosition: string;
  text: string;
  date: string;
}

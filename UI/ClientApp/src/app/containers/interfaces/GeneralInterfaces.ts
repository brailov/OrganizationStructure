
export interface IReport {
  text: string;
  date: string;
}

export interface IEmployeeDetailsDtos {
  FirstName: string;
  LastName: string;
  Position: string;
  assignedTasks: ITask[];
}

export interface ITask {
  text: string;
  assignDate: string;
  dueDate: string;
}

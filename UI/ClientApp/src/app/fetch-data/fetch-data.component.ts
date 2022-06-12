import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { Console } from 'console';
import { Router } from '@angular/router';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls: ['./fetch-data.component.css']  
})
export class FetchDataComponent {
  
  public employees: Employees[];
 
  constructor(http: HttpClient,
              @Inject('BASE_URL') baseUrl: string,
              public router : Router) {
 
    http.get<Employees[]>(baseUrl + 'Employee').subscribe(result => {
      debugger
      this.employees = result;
    }, error => console.error(error));
  }

  public NavToEmployeeDetails(_employee) {
    
    this.router.navigate(['/workerdetails',_employee ]);
   
  }
}

interface Employees {
  FirstName: string;
  LastName: string;
  Position: string;
}

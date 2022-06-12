import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute, Params } from '@angular/router';

@Component({  // counter.component'
  selector: 'app-employee-component',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']  
})
export class EmployeeComponent implements OnInit {

  public _baseUrl: string = undefined;

  constructor(
    public http: HttpClient,
    @Inject('BASE_URL') baseUrl: string,
    public router: Router,
    public actRoute: ActivatedRoute) { this._baseUrl = baseUrl;}

  ngOnInit() {

    this.actRoute.params.subscribe(result => {
      let data1 = result;
      if (data1)       
        this.GetEmployeeDetails(data1);
      
    }, error => console.error(error));    
  }

  GetEmployeeDetails(data: Params) {

    if (!data) return;    
    this.http.get<Employees[]>(this._baseUrl + 'Employee/byName?firstName=' + data.firstName + '&lastName=' + data.lastName + '&position=' + data.position +'').subscribe(result => {
      debugger;
      let ans = result;
    }, error => console.error(error));
  }  
}

interface Employees {
  FirstName: string;
  LastName: string;
  Position: string;
}

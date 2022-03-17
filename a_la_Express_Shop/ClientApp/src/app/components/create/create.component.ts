import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/services/httpService.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  constructor(private http:HttpClient) { }

  ngOnInit() {
  }

  result:any

  /*search(){
  this.HttpService.post('https://localhost:44307/create/1').subscribe((value)=> this.result = value)
  };*/
}
  


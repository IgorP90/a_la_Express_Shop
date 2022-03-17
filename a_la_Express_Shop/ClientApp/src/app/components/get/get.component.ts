import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpService } from 'src/app/services/httpService.service';


@Component({
  selector: 'app-get',
  templateUrl: './get.component.html',
  styleUrls: ['./get.component.css']
})
export class GetComponent implements OnInit {

  constructor(private httpService:HttpClient) { }

  result:any;
  error:string;

  ngOnInit() {}

  dddf(){ 
     this.httpService.get('https://localhost:44307/api/Home/get/1')
      .subscribe(value=>{this.result = value
      },
      error =>{  
        this.error = error      
      });
  } 
    
}
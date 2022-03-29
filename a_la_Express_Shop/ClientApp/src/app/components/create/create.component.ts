import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/interfaces/product.interface';
import { HttpService } from 'src/app/services/httpService.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  constructor(private httpService:HttpClient) { }

  ngOnInit() {
  }
  
  product:Product
  result:any

  create(){
  this.httpService.post('https://localhost:44307/api/Home/post/product ', this.product)
  .subscribe((value:Product)=> this.result = value)
  };
}
  


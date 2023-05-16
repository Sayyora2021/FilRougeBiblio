import { Component} from '@angular/core';
import {IMotClef} from 'src/Interfaces/IMotClef';
import { MotclefsService } from 'src/Services/motclefs.service';
import { FormsModule } from '@angular/forms';
import {Router} from '@angular/router';



@Component({
  selector: 'app-create-motclefs',
  templateUrl: './create-motclefs.component.html',
  styleUrls: ['./create-motclefs.component.css']
})
export class CreateMotclefsComponent {

  constructor(private motclefsService: MotclefsService, private router: Router){

  }
 tag?:string;
  
  create(){
   console.log(this.tag);
   if(this.tag!= undefined){
    this.motclefsService.create({tag:this.tag, livres:[], id: 0})
    this.router.navigate(['/MotClefs']);
   }
   
  }
}

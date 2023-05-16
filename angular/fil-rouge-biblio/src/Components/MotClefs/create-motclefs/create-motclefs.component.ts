import { Component} from '@angular/core';
import {IMotClef} from 'src/Interfaces/IMotClef';
import { MotclefsService } from 'src/Services/motclefs.service';
import { FormsModule } from '@angular/forms';



@Component({
  selector: 'app-create-motclefs',
  templateUrl: './create-motclefs.component.html',
  styleUrls: ['./create-motclefs.component.css']
})
export class CreateMotclefsComponent {

  motclef: IMotClef = {tag:'', livres:[], id: 0}

  constructor(private motclefsService: MotclefsService){

  }
  create(){
    
    this.motclefsService.create(this.motclef);
  }
}

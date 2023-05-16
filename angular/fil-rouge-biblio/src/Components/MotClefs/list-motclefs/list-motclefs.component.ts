import { Component } from '@angular/core';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-list-motclefs',
  templateUrl: './list-motclefs.component.html',
  styleUrls: ['./list-motclefs.component.css']
})
export class ListMotclefsComponent {
motclefs?: IMotClef[];
constructor(private motclefsService: MotclefsService){
  this.motclefsService.listAll().subscribe(
    (data: IMotClef[])=>{
      this.motclefs=data;
    }
  )
}
}

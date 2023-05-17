import { Component, OnInit } from '@angular/core';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-list-motclefs',
  templateUrl: './list-motclefs.component.html',
  styleUrls: ['./list-motclefs.component.css']
})
export class ListMotclefsComponent implements OnInit{
motclefs?: IMotClef[];
nomFiltre: string = '';
constructor(private motclefsService: MotclefsService){
  
}
  ngOnInit(): void {
    this.motclefsService.listAll().subscribe(
      (data: IMotClef[])=>{
        this.motclefs=data;
      }
    )
  }
  filtrer() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.motclefs)
        this.motclefs = this.motclefs.filter(motClef =>
          motClef.tag.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.motclefs = this.motclefs;
    }
  }
}

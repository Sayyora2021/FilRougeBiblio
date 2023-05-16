import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-update-motclefs',
  templateUrl: './update-motclefs.component.html',
  styleUrls: ['./update-motclefs.component.css']
})
export class UpdateMotclefsComponent {
  motclefs : IMotClef = {id:0,tag:'',livres:[]};

  constructor(private motclefsService: MotclefsService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    motclefsService.details(parseInt(id)).subscribe(
      (data: IMotClef) => {
        this.motclefs = data;
      });
  }

  update(){
    this.motclefsService.update(this.motclefs,this.motclefs.id);
    this.router.navigate(['/MotClefs']);
  }
}

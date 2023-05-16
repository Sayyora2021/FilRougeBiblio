import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-delete-motclefs',
  templateUrl: './delete-motclefs.component.html',
  styleUrls: ['./delete-motclefs.component.css']
})
export class DeleteMotclefsComponent {
  motclefs : IMotClef = {id:0,tag:'',livres:[]};

  constructor(private motclefsService: MotclefsService, private router: Router, private activatedRoute: ActivatedRoute){
    const id = activatedRoute.snapshot.paramMap.get('id');
    if(id)
    motclefsService.details(parseInt(id)).subscribe(
      (data: IMotClef) => {
        this.motclefs = data;
      });
  }

  delete(){
    this.motclefsService.delete(this.motclefs.id);
    //this.router.navigate(['/MotClefs']);
  }
}

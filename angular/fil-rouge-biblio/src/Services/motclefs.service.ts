import { Injectable } from '@angular/core';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, map } from 'rxjs';
import { apiconfig } from 'apiconfig';



@Injectable({
  providedIn: 'root'
})
export class MotclefsService {

  path = apiconfig.adress + '/MotClefs';
  constructor(private http: HttpClient) { }

  update(motclef:IMotClef){
    
    this.http.put<IMotClef>(this.path + `/Edit?id=${motclef.id}&tag=${motclef.tag}`,motclef).subscribe();
    
  }

  create(motclef:IMotClef){
    this.http.post<IMotClef>(this.path+'/Create',motclef).subscribe();
    
  }
  
  details(id:number) : Observable<IMotClef>{
    return this.http.get<IMotClef>(this.path+'/Details/' + id);
  }


  delete(id:number){
    this.http.delete<IMotClef>(this.path+'/Delete/'+id).subscribe();
  }


  listAll() : Observable<IMotClef[]>{

    return this.http.get<IMotClef[]>(this.path).pipe(
    map((data: IMotClef[]) => {
      return data;
    })
  );

  }
}

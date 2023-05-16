import { Injectable } from '@angular/core';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, map } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class MotclefsService {

  constructor(private http: HttpClient) { }

  update(motclef:IMotClef){
    
    this.http.put<IMotClef>(`https://localhost:7120/api/MotClefs/Edit?id=${motclef.id}&tag=${motclef.tag}`,motclef).subscribe();
    
  }

  create(motclef:IMotClef){
    this.http.post<IMotClef>('https://localhost:7120/api/MotClefs/Create',motclef).subscribe();
    
  }
  details(id:number) : Observable<IMotClef>{
    return this.http.get<IMotClef>('https://localhost:7120/api/MotClefs/Details/' + id);
  }
  delete(id:number){
    this.http.delete<IMotClef>('https://localhost:7120/api/MotClefs/Delete/'+id).subscribe();
  }
  listAll() : Observable<IMotClef[]>{

    return this.http.get<IMotClef[]>('https://localhost:7120/api/MotClefs').pipe(
    map((data: IMotClef[]) => {
      return data;
    })
  );

  }
}

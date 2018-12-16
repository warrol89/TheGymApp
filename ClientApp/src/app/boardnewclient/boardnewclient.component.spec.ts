import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardnewclientComponent } from './boardnewclient.component';

describe('BoardnewclientComponent', () => {
  let component: BoardnewclientComponent;
  let fixture: ComponentFixture<BoardnewclientComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BoardnewclientComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BoardnewclientComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

from django.urls import path
from .views import ArticleListView, ArticleDetailView, ArticleAPIView, ArticleDetailAPIView


urlpatterns = [
    #path('article/',ArticleListView ),
    path('article/',ArticleAPIView.as_view()),
    path('detail/<int:pk>',ArticleDetailAPIView.as_view()),
    #path('detail/<int:pk>',ArticleDetailView )
    #path('generic/article/',GenericAPIView.as_view()),
]
